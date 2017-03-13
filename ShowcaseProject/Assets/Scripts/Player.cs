using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for 
    private Rigidbody2D myRigigdBody;
    public float speed;
    private bool facingRight;
	void Start ()
    {
        facingRight = true;
        myRigigdBody = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        HandMovement(horizontal);
        Flip();

    }
    private void HandMovement(float horizontal)
    {
      
        myRigigdBody.velocity = new Vector2(horizontal * speed, myRigigdBody.velocity.y); // x = -1, y= 0;
        //myRigigdBody.velocity = Vector2.right;
    }
    private void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;


    }
}

