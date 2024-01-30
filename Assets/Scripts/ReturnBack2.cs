using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBack2 : MonoBehaviour
{
    public GameObject _mainMenu;
    public GameObject _GO;

    private void Awake()
    {

    }
    public void ReturnBackSet()
    {
        _mainMenu.SetActive(true);
        _GO.SetActive(false);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}

