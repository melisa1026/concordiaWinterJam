using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour
{
    // 0: lumberjeck
    // 1: car
    // 2: bench

    public int thrower;
    public GameObject tree;

    void Start()
    {
        GetComponent<Animator>().enabled = false;

        if(thrower == WhoThrew.thrower)
        {
            GetComponent<Animator>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
        tree.SetActive(false);
    }

    public void switchToTree()
    {
        tree.SetActive(true);
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
