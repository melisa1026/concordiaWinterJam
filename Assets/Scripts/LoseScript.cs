using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
        if (thrower == WhoThrew.thrower)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        tree.SetActive(false);

        StartCoroutine(throwObject());
    }

    public IEnumerator throwObject()
    {
        yield return new WaitForSeconds(1);
        if(thrower == WhoThrew.thrower)
        {
            GetComponent<Animator>().enabled = true;
        }
    }

    public void switchToTree()
    {
        tree.SetActive(true);
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
