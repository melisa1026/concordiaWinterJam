using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    // Start is called before the first frame update
    float SnoringSeconds;
    float CarSeconds;
    float WalkingSeconds;

    public AudioSource Snoring;
    public AudioSource Car;
    public AudioSource Walking;

    void Start()
    {
        SnoringSeconds = randTime();
        CarSeconds = randTime();
        WalkingSeconds = randTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time> SnoringSeconds)
        {
            Snoring.Play();
            SnoringSeconds = Time.time + randTime();
        }

        if (Time.time > CarSeconds)
        {
            Car.Play();
            CarSeconds = Time.time + randTime();
        }

        if (Time.time > SnoringSeconds)
        {
            Walking.Play();
            WalkingSeconds = Time.time + randTime();
        }


    }

    float randTime()
    {
        return Random.value * 2 + 2;
    }

}
