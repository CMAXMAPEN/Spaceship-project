using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public float maxRotateValue = 200;
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(0,1)*maxRotateValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
