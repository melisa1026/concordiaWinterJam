using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioSource CatMeow;

    float CatTime;

    // Start is called before the first frame update
    void Start()
    {
        CatTime = randTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > CatTime)
        {
            CatTime = Time.time + randTime();
            CatMeow.Play();
        }
    }

    float randTime()
    {
        return Random.value * 10 + 10;
    }
}
