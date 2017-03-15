using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for 
    private Rigidbody2D myRigigdBody;

    [SerializeField]
    public float speed;

    private Animator myAnimator;
    private bool facingRight;
	void Start ()
    {
        facingRight = true;
        myRigigdBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        HandMovement(horizontal);
        Flip(horizontal);
    }
    private void HandMovement(float horizontal)
    {
      
        myRigigdBody.velocity = new Vector2(horizontal * speed, myRigigdBody.velocity.y);
        myAnimator.SetFloat("speed",Mathf.Abs(horizontal));// x = -1, y= 0;
        //myRigigdBody.velocity = Vector2.right;
    }
    private void Flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }


    }
}

