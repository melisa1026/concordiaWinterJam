using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShaker : MonoBehaviour
{
    float originalYPosition;
    private float shakeTime;
    
    // Start is called before the first frame update
    void Start()
    {
        originalYPosition= transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shake(0.2f);

        }
    }

    private void LateUpdate()
    {
        if (shakeTime > 0)
        {
            shakeTime -= Time.deltaTime;

            float amountX = Random.Range(-0.1f, 0.1f);
            float amountY = Random.Range(-0.1f, 0.1f);
            transform.position += new Vector3(amountX, amountY, 0f);
        }
        else
        {
            transform.position  = new Vector3(transform.position.x , originalYPosition, transform.position.z);
        }
    }

    public void Shake(float timing)
    {
        shakeTime=timing;
    }
}
