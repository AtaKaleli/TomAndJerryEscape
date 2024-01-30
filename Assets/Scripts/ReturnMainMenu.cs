using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainMenu : MonoBehaviour
{
    

    private void Awake()
    {

    }
    public void ReturnBackSet()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitProgram()
    {
        Application.Quit();
    }
}
