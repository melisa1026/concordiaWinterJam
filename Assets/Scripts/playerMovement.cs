using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private bool rooted;
    private bool faceRight = true;

    // Start is called before the first frame update
    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown("space")){
            rooted = true;
            playerRB.velocity = new Vector2(0, 0);
        }

        if (!rooted)
        {
            float moveX = Input.GetAxisRaw("Horizontal");

            if (faceRight && moveX < 0)
            {
                faceRight = !faceRight;
                transform.Rotate(0f, 180f, 0f);
            }

            if (!faceRight && moveX > 0)
            {
                faceRight = !faceRight;
                transform.Rotate(0f, 180f, 0f);
            }
            playerRB.velocity = new Vector2(moveX * 7f, 0);
        }


        if (Input.GetKeyUp("space"))
        {
            rooted = false;
        }
        //if (Input.GetButtonDown("Space"))
        //{

        //}
    }
}
