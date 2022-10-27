using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipSpeed : MonoBehaviour
{
    public float spaceshipSpd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalMovement, verticalMovement;


        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        Debug.Log("H: " + horizontalMovement + "V: " + verticalMovement);

        Vector2 newVelocity = new Vector2(horizontalMovement, verticalMovement);
        GetComponent<Rigidbody2D>().velocity = newVelocity * spaceshipSpd;
        

    }
}
