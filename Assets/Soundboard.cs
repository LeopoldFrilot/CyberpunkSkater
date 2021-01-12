using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundboard : MonoBehaviour
{
    public AudioClip starPickup;
    public AudioClip fuelPickup;
    public AudioClip crash;
    public AudioClip teleport;
    public AudioClip takeFlight;
    
    public void PlayClip(AudioClip clip, float volume)
    {
        GetComponent<AudioSource>().PlayOneShot(clip, volume);
    }
}
