using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public float playerSpeed;
    public float minX, maxX, minY, maxY;
    public GameObject laserBeam, laserBeamSpawn;
    public float fireRate = 0.25f;
    private float timer = 0;


    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalMovement;
        float verticalMovement;
        horizontalMovement = Input.GetAxis("Horizontal"); //"a" and "d" inputs
        verticalMovement = Input.GetAxis("Vertical"); //"w" and "s" input

        Vector2 newVelocity = new Vector2(horizontalMovement, verticalMovement);// setting default speed, altered by player speed
        GetComponent<Rigidbody2D>().velocity = newVelocity * playerSpeed; //the default movement speed

        float newX, newY;

        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x,minX,maxX);
        newY = Mathf.Clamp(GetComponent < Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY); //setting the new position of our ship when moving


        if(Input.GetAxis("Fire1") > 0 && timer > fireRate) //if right click is pressed and there has been enough time between shots
        {
            //GameObject.Instantiate();

            GameObject goObj;
            goObj = Instantiate(laserBeam, laserBeamSpawn.transform.position, laserBeamSpawn.transform.rotation);
            //spawning our laser beams, setting their position and rotation relative to ship
            goObj.transform.Rotate(new Vector3(0, 0, 90)); 
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
