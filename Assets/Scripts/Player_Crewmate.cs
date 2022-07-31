using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Player_Crewmate : MonoBehaviour
{
    public float moveSpeed = 1.6f;
    public Rigidbody rig;
    public float jumpForce = 5.0f;
    private int maxjumps = 0;
    private bool powerup = false;
    private bool isGrounded = true;
    private GameObject platform;


    void Update()
    {
        // get the horizontal and vertical inputs
        float x = Input.GetAxis("Horizontal")*moveSpeed;
        float z = Input.GetAxis("Vertical")*moveSpeed;
        // set our velocity based on our inputs
        rig.velocity = new Vector3(x, rig.velocity.y, z);
        // create a copy of our velocity variable and
        // set the Y axis to be 0
        Vector3 vel = rig.velocity;
        vel.y = 0;


        // if we're moving, rotate to face our moving direction
        if(vel.x != 0 || vel.z != 0)
        {
            transform.forward = vel;
        }

        // jump if we're grounded and we press the Space key
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            
            isGrounded = false;
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // game over if we fall off the map
        if(transform.position.y < -10)
        {
            StaticClass.Lives--;
            transform.position = new Vector3(0, 0, 0);
        }
    }

    // called when we collide with another object
    private void OnCollisionEnter(Collision collision)
    {
        // are we standing on the surface?
        if(collision.contacts[0].normal == Vector3.up)
        {
            isGrounded = true;
            if (maxjumps > 0 && powerup == true)
            {
                maxjumps--;
            }
            else if (maxjumps == 0 && powerup == true)
            {
                moveSpeed -= 4.0f;
                jumpForce -= 6.0f;
                powerup = false;
            }
        }
        if (collision.gameObject.CompareTag("Shield") && powerup == false)
        {
            moveSpeed += 4.0f;
            jumpForce += 6.0f;
            maxjumps = 3;
            powerup = true;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Shield") && powerup == true)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("FireStarter"))
        {
            platform = GameObject.FindGameObjectWithTag("Platform");
            platform.GetComponent<BoxCollider>().enabled = true;
            StaticClass.Walknow = true;

            // transform.position = new Vector3(-2, 1, 26);
        }
    }

    // called when the player hits an enemy or falls off the level
    public void GameOver ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
