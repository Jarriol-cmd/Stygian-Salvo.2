using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Slider musicSlider;
    public Slider sfxSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("Musicvolume");
        AudioScript.instance.audioVolume = PlayerPrefs.GetFloat("Musicvolume");
        //AudioScript.instance.Play("music");

        sfxSlider.value = PlayerPrefs.GetFloat("Sfxvolume");
        AudioScript.instance.sfxVolume = PlayerPrefs.GetFloat("Sfxvolume");

    }

    // Update is called once per frame
    void Update()
    {
        //AudioScript.instance.ChangeAudioSourceVolume("music", AudioScript.instance.audioVolume);

    }
}
