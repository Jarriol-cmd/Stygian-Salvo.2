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

        if (PlayerPrefs.GetFloat("SfxVolume") <= 0)
        {
            sfxSlider.value = 1f;
        }

        if (PlayerPrefs.GetFloat("AudioVolume") <= 0)
        {
            audioSlider.value = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        AudioScript.instance.ChangeAudioSourceVolume("Music", AudioScript.instance.audioVolume);

    }
}
