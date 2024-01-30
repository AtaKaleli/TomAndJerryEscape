using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteGame : MonoBehaviour
{
    public AudioSource _audioSource;
    public Toggle _toggleSource;

    


    public void MuteEntry()
    {
        bool checkToggle = _toggleSource.isOn;
        if (checkToggle)
        {

            _audioSource.Pause();
        }
        else
            _audioSource.UnPause();
    }
}
