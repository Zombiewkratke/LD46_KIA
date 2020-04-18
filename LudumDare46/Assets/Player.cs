using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    private float axisX;
    private float axisZ;
    private Rigidbody2D rigidBD;
    public Collider2D Collider;
    public float moveSpeed = 5;
    public float maxHealth = 100;
    public float Health;

    void Start()
    {
        Health = maxHealth;
        rigidBD = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        
        axisX = Input.GetAxis("Horizontal");
        axisZ = Input.GetAxis("Vertical");
        rigidBD.velocity = new Vector2(axisX,rigidBD.velocity.y)* moveSpeed;
        
        //fix scale rotation
        /*
        if(axisX > 0)
        {
            transform.localScale = new Vector2(1,1);
        }
        else if(axisX < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        */
    }
    
}
