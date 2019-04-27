using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
	//Author: Tim Allen
	//Date: 4/26/19

	// Start is called before the first frame update
	//Variable Declarations
	public bool facingRight =true;
	public int moveSpeed =15;
	public int jumpPower = 15000;
	public float moveDelta;


    // Update is called once per frame
    void Update()
    {
		MovePlayer();
    }
	void MovePlayer()
	{
		//CONTROLS
			//sideways movement
		moveDelta = Input.GetAxis("Horizontal");
		//jump
		if (Input.GetButtonDown("Jump"))
		{
			Jump();
		}
		//ANIMATION
		//CHARACTER DIRECTION
		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((moveDelta * moveSpeed), gameObject.GetComponent<Rigidbody2D>().velocity.y);


	}
	public void Jump()
	{
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
		Debug.Log(Vector2.up * jumpPower);
	}
}
