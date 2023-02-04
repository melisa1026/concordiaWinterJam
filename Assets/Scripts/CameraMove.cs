using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;
    private float x;
    public float min;
    public float max;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = player.GetComponent<Transform>().position.x;
        transform.position = new Vector3(x,transform.position.y,transform.position.z);

        if ( player.GetComponent<Transform>().position.x <= min )
            transform.position = new Vector3(min,transform.position.y,transform.position.z);
        else if ( player.GetComponent<Transform>().position.x >= max)
            transform.position = new Vector3(max,transform.position.y,transform.position.z);
    
    }



}