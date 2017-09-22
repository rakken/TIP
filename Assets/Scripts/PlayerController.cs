using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public int deplacement;
    public int vertical = 0;
    public int horizontal = 1;


    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;    //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {

        if (deplacement > 0)
        {
            //Use the two store floats to create a new Vector2 variable movement.
            Vector2 movement = new Vector2(horizontal, vertical);

            //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
            rb2d.velocity = movement * speed;
            //rb2d.AddForce(movement);
        }
        else
        {
            rb2d.velocity = Vector2.zero;

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            deplacement -= 1;
        }

    }

    public void SetDeplasement(int deplacement)
    {
        this.deplacement = deplacement;
    }
    public int GetDeplacement(){
        return deplacement;
    }

    public void SetVertical(int vertical)
    {
        this.vertical = vertical;
    }

    public void SetHorizontal(int horizontal)
    {
        this.horizontal = horizontal;
    }

}

