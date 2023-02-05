using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeper : MonoBehaviour
{
    Collider2D SleepCollider;
    // Start is called before the first frame update
    void Start()
    {
        SleepCollider = GetComponent<Collider2D>();
        SwitchCollider();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchCollider()
    {
        SleepCollider.enabled =  !SleepCollider.enabled;

    }
}
