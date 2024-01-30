using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseController : MonoBehaviour
{

    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private float _moveSpeed = 7;
    private static float maxCheese = 4;
    public GameObject _weaponDog;
    public float _flingForce = 500;
    //public GameObject _victoryText;
    public GameObject _loseText;
    public GameObject _restartGame;
    private AudioSource _audioSource;
    public AudioSource _SFXsound;
    public AudioClip _collectSmallCheese;
    private float _flingCooldown = 2;
    private float _flingTimer;
    
    public UIManager _uiManager;
    public static int _sceneNumber = 1;
    public bool _isDead;
    public bool _isGameEnd;


    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _audioSource = GetComponent<AudioSource>();
        _flingTimer = _flingCooldown;

    }

    void Update()
    {
        if(_uiManager == null)
        {
            _uiManager = FindObjectOfType<UIManager>();
        }
        _uiManager.UpdateDogReload(_flingTimer / _flingCooldown);
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            _isDead = false;
            SceneManager.LoadScene(_sceneNumber);
        }

        _flingTimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && _flingTimer>=_flingCooldown)
        {
            _audioSource.Play();
            Vector3 spawnDog = transform.position + new Vector3(0.5f, 0, 0);
            GameObject newDog = Instantiate(_weaponDog, spawnDog, Quaternion.identity);
            Rigidbody2D dogRb = newDog.GetComponent<Rigidbody2D>();
            dogRb.AddForce(new Vector2(_flingForce,0));
            _flingTimer = 0;
        }
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 nextMove = transform.position + moveInput * _moveSpeed * Time.deltaTime;

        _rb.MovePosition(nextMove);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if (otherGO.tag == "Cheese")
        {
            _SFXsound.PlayOneShot(_collectSmallCheese);
            Destroy(otherGO);
            
            maxCheese -= 1;
            if (maxCheese == 0)
            {
                _isGameEnd = true;
                _uiManager.gameObject.SetActive(false);
                SceneManager.LoadScene(5);
                
                

            }
            else
            {
                _sceneNumber++;
                SceneManager.LoadScene(_sceneNumber);
            }

            
        }
        

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if(otherGO.tag == "Spike" || otherGO.tag == "EnemyNotMoving" || otherGO.tag=="EnemyMoving")
        {
            

            _loseText.SetActive(true);
            _restartGame.SetActive(true);
            _sr.enabled = false;
            Time.timeScale = 0;
            _isDead = true;
        }
        
    }

   

    
}
