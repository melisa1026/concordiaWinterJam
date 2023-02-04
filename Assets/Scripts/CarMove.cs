using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

public float speed;
public float min;
public float max;
private float x;
private float angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        x += speed * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if ( transform.position.x >= max && speed > 1 )
        {
                angle += 180;
                transform.eulerAngles = new Vector3(0,angle,0);
                speed = speed*-1;
        }
        if ( transform.position.x <= min && speed < -1 )
        {
                angle += 180;
                transform.eulerAngles = new Vector3(0,angle,0);
                speed = speed*-1;
        }
    }
}
