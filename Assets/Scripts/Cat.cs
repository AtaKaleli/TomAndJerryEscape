using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private AudioSource _audioSource;
    private SpriteRenderer _sr;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGO = collision.gameObject;
        if (otherGO.tag == "dog")
        {
            _audioSource.Play();
            _sr.enabled = true;
            _sr.color = Color.red;

            StartCoroutine(DestroyAfterSound());
        }
    }

    IEnumerator DestroyAfterSound()
    {
        // Wait for the duration of the sound clip
        yield return new WaitForSeconds(_audioSource.clip.length);

        // Destroy the gameObject after the sound has finished playing
        Destroy(gameObject);
        
    }
}
