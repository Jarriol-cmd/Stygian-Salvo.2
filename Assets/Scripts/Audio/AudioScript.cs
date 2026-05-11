using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public float audioVolume, sfxVolume;

    public float audioAudio, sfxAudio;

    public static AudioScript instance;

    public AudioMixer mixerp;

    public AudioSettings[] sounds;

    public bool mute;

    void Awake()
    {

        // if instance is null, store a reference to this instance
        if (instance == null)
        {
            // a reference does not exist, so store it
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            Destroy(gameObject);
        }

        foreach (AudioSettings s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;

            s.source.outputAudioMixerGroup = s.mixerGroup;

        }

        if (PlayerPrefs.HasKey("AudioVolume") == true)
        {

            audioAudio = PlayerPrefs.GetFloat("AudioVolume");
        }

        if (PlayerPrefs.HasKey("SfxVolume") == true)
        {

            sfxAudio = PlayerPrefs.GetFloat("SfxVolume");
        }

    }

    void Update()
    {

    }
    public void ChangeAudioSourceVolume(string name, float vol)
    {
        AudioSettings s = Array.Find(sounds, SoundSettings => SoundSettings.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "Not found!");
            return;
        }
        s.source.volume = vol;


    }

    public void Play(string name)
    {
        AudioSettings s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void PlaySFX(string name)
    {
        AudioSettings s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = sfxVolume;
        s.source.Play();
    }

}

