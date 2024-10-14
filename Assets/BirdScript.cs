using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //bird variables
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;
    public static bool birdIsAlive = true;
    //camera and state variables
    public int maxPoint = 12;
    public int minPoint = -12;
    public gameLogicScript logic;
    //audio variables
    public AudioClip wingFlap;
    public float flapVolume = 5;
    public SpriteRenderer wing;
    // Start is called before the first frame update
    void Start()
    {
        birdIsAlive = true;
        logic = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameLogicScript>();
        wing = GameObject.FindGameObjectWithTag("Wing").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive && !PauseMenu.isPaused) {
            AudioSource.PlayClipAtPoint(wingFlap, Camera.main.transform.position, flapVolume);
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        if (myRigidBody.velocity.y > 0)
        {
            wing.flipY = true;
        }
        else
        {
            wing.flipY = false;
        }
        if (transform.position.y <= minPoint || transform.position.y >= maxPoint)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
