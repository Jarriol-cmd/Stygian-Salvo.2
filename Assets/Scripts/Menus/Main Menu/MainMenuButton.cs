using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    public AudioMixer mixer;

    InputAction submit;
    public Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        Button button = GetComponent<Button>();

        OnSelect();

        submit = InputSystem.actions.FindAction("Submit");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(submit.triggered)
        {
            
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync("Survival");
    }

    public void RageQuit()
    {
        Application.Quit();
    }

    private void OnSelect()
    {
        button.Select();
    }



    public void ChangeMusicVolume(float volume)
    {

        AudioScript.instance.audioVolume = volume;
        PlayerPrefs.SetFloat("AudioVolume", AudioScript.instance.audioVolume);
        
        mixer.SetFloat("AudioVol", Mathf.Log10(volume) * 20);
    }

    public void ChangeSFXVolume(float sVolume)
    {
        AudioScript.instance.sfxVolume = sVolume;
        PlayerPrefs.SetFloat("SfxVolume", AudioScript.instance.sfxVolume);
        
        mixer.SetFloat("SFXVol", Mathf.Log10(sVolume) * 20);
    }

    public void Soundtest()
    {
        AudioScript.instance.PlaySFX("Sound Test");
    }

}
