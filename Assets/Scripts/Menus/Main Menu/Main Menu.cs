using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Slider audioSlider;
    public Slider sfxSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSlider.value = PlayerPrefs.GetFloat("AudioVolume");
        AudioScript.instance.audioVolume = PlayerPrefs.GetFloat("AudioVolume");
        AudioScript.instance.Play("Music");

        sfxSlider.value = PlayerPrefs.GetFloat("SfxVolume");
        AudioScript.instance.sfxVolume = PlayerPrefs.GetFloat("SfxVolume");

    }

    // Update is called once per frame
    void Update()
    {
        AudioScript.instance.ChangeAudioSourceVolume("Music", AudioScript.instance.audioVolume);

    }
}
