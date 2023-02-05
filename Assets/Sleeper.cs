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
        //Toggle the Collider on and off when pressing the space bar
        SleepCollider.enabled =  !SleepCollider.enabled;
        //Output to console whether the Collider is on or not

        Debug.Log("Collider.enabled = " + SleepCollider.enabled);
    }
}
