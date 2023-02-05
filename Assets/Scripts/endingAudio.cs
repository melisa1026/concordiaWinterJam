using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingAudio : MonoBehaviour
{
    public GameObject romanticMusicSource, axAudioSource;

    public void volumeRomanticMusic()
    {
        romanticMusicSource.GetComponent<AudioSource>().volume = 1;
    }

    public void playRomanticMusic()
    {
        romanticMusicSource.GetComponent<AudioSource>().Play();
    }

    public void playAxSound()
    {
        axAudioSource.GetComponent<AudioSource>().Play();
    }
}
