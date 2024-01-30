using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToScreen : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _GO;

    private void Awake()
    {

    }
    public void MoveScreen()
    {
        _mainMenu.SetActive(false);
        _GO.SetActive(true);
    }
}

