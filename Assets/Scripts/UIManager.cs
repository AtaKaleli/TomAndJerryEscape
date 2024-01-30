using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI _shootTimer;
    public TMPro.TextMeshProUGUI _poopReload;
    public Image _dogReloadBG;
    public MouseController _mouse;
    private float timer;
    public static UIManager _instance;

    private void Awake()
    {
        _poopReload.text = "Dog Reload: ";
        


    }

    
    
    
    private void Update()
    {
        if(_mouse == null)
        {
            _mouse = FindObjectOfType<MouseController>();
        }
        timer += Time.deltaTime;
        _shootTimer.text = "Time \n" + timer.ToString("0.00"); 
    }
    
    public void UpdateDogReload(float readyness)
    {
        _dogReloadBG.fillAmount = readyness;
    }



}
