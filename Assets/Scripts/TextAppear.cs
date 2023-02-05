using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource source;

    public void appear()
    {
        canvas.SetActive(true);
        source.Play();
    }
}
