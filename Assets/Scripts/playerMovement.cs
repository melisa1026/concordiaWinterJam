using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float speed;
    private bool rooted;
    private bool faceRight = true, standing = true;
    public bool caught = false;

    // Start is called before the first frame update
    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!caught)
        {
            if (Input.GetKeyDown("space"))
            {
                rooted = true;
                playerRB.velocity = new Vector2(0, 0);
                GetComponent<Animator>().Play("TreeRooting");
            }
            if (Input.GetKeyUp("space"))
            {
                GetComponent<Animator>().Play("TreeUnrooting");
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

                playerRB.velocity = new Vector2(moveX * speed, 0);

                // player stands when not moving, walks when moving
                if (playerRB.velocity == new Vector2(0, 0))
                {
                    GetComponent<Animator>().Play("standTree");
                    standing = true;
                }
                if (standing && playerRB.velocity != new Vector2(0, 0))
                {
                    GetComponent<Animator>().Play("TreeWalkAnim");
                    standing = false;
                }
            }
        }
        //if (Input.GetButtonDown("Space"))
        //{

        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!rooted)
        {
            print("Caught by " + collision.gameObject.tag);
            if ((collision.gameObject.tag).CompareTo("LumberJack") == 0)
            {
                WhoThrew.thrower = 0;
            }
            if ((collision.gameObject.tag).CompareTo("ClownCar") == 0)
            {
                WhoThrew.thrower = 1;
            }
            
            if ((collision.gameObject.tag).CompareTo("Sleeper") == 0)
            {
                WhoThrew.thrower = 2;
            }

            playerRB.velocity = Vector2.zero;
            caught = true;
            SceneManager.LoadScene("Lose");

        }

        else
        {
            print("SAFE");
        }
    }

    public void unroot()
    {
        rooted = false;
    }
}
