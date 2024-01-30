using UnityEngine;
using UnityEngine.UI;

public class audioSettings : MonoBehaviour
{
    public AudioSource _audioSource;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = _audioSource.volume;
    }

    
    public void OnVolumeEntrySliderChanged(float newVolume)
    {
        _audioSource.volume = newVolume;
    }
    
}
