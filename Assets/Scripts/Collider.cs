using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{

 private void OnTriggerEnter2D(Collider2D other)
 {
    Debug.Log("hit detected");
 }

}
