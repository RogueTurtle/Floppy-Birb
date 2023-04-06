using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapVel = 10;
    public Logic logic;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            myRigidBody.velocity = Vector2.up * flapVel;
        }
        if (transform.position.y > 15 || transform.position.y < -15)
        {
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        alive = false;
    }
}
