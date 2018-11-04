using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class TurnMusicON : MonoBehaviour
{
    public void turnOn()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
}