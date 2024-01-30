using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _gameObject;

    private void Awake()
    {
        
    }
    public void ReturnBackMenu()
    {
        _mainMenu.SetActive(true);
        _gameObject.SetActive(false);
    }
}
