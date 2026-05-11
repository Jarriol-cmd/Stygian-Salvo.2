using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AudioSettings
{

    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    [Range(.1f, 2f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;

    public bool loop;


    public AudioMixerGroup mixerGroup;


}

