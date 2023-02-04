using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
   
    // Start is called before the first frame update
    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        playerRB.velocity = new Vector2(moveX*7f,0);

        //if(Input.GetButtonDown("Horizontal"))
                //playerRB.velocity = new Vector2 (14f, 0);
    }
}
