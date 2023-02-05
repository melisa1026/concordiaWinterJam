using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float startPos;
    public float distance;
    public float idleTime = 3;
    public float speed;
    float waitingTime = -1;
    bool facingRight = true;
    bool idle = false;
    float angle = 0;



    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time > waitingTime)
        {
            if (transform.position.x <= startPos + distance && transform.position.x >= startPos)
            {
                if (idle)
                {
                    angle = facingRight ? 0 : 180;

                    transform.rotation = Quaternion.Euler(0f, angle, 0);  
                    idle = false;
                }
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (idle == false)
            {
                idle = true;
                facingRight = !facingRight;
                waitingTime = Time.time + idleTime;
                transform.Translate(Vector2.left);
            }
        }
        else
        {
            transform.Rotate(0f, 180 / idleTime * Time.deltaTime, 0f);
        }
            


    }
}
