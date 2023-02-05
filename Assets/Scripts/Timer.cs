using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    Stopwatch timer;
    public TextMeshProUGUI time;    

    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();
        time = gameObject.GetComponent<TextMeshProUGUI>();
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
