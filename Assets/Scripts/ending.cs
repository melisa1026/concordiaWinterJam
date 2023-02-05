using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// attached to the trees


public class ending : MonoBehaviour
{

    public GameObject jenardMouth, jeniceMouth, textbox, bgTextbox;

    void Start()
    {
        GetComponent<Animator>().Play("stillForTalking");
        jenardMouth.GetComponent<Animator>().Play("paused");
        jeniceMouth.GetComponent<Animator>().Play("pausedJenice");

        StartCoroutine(end());
    }

    public IEnumerator end()
    {
        yield return new WaitForSeconds(1);

        // Jenice!
        jenardMouth.GetComponent<Animator>().Play("janard mouth");
        bgTextbox.SetActive(true);
        textbox.GetComponent<TextMeshProUGUI>().text = "Jenice!";
        
        yield return new WaitForSeconds(1);
        bgTextbox.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        bgTextbox.SetActive(true);

        // Jenard!
        jeniceMouth.GetComponent<Animator>().Play("jenice mouth");
        jenardMouth.GetComponent<Animator>().Play("paused");
        textbox.GetComponent<TextMeshProUGUI>().text = "Jenard!";

        yield return new WaitForSeconds(1);
        bgTextbox.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        bgTextbox.SetActive(true);

        // You came back for me!
        textbox.GetComponent<TextMeshProUGUI>().text = "You came back for me!";

        
        yield return new WaitForSeconds(2);

        // of course I came back for you baby
        jenardMouth.GetComponent<Animator>().Play("janard mouth");
        jeniceMouth.GetComponent<Animator>().Play("pausedJenice");
        textbox.GetComponent<TextMeshProUGUI>().text = "Of course I came back for you, Baby!";

        yield return new WaitForSeconds(3);
        bgTextbox.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        bgTextbox.SetActive(true);

        // I LOVE YOU
        jeniceMouth.GetComponent<Animator>().Play("jenice mouth");
        jenardMouth.GetComponent<Animator>().Play("janard mouth");
        textbox.GetComponent<TextMeshProUGUI>().text = "I LOVE YOU";
        
        yield return new WaitForSeconds(1);
        bgTextbox.SetActive(false);

        // kissy kissy
        jenardMouth.SetActive(false);
        jeniceMouth.SetActive(false);
        GetComponent<Animator>().Play("kissyKissy");
    }
}
