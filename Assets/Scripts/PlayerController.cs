using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//Author: Tim Allen
	//Date: 4/26/19

	// Start is called before the first frame update
	//Variable Declarations
	public bool facingRight =true;
	public int moveSpeed =15;
	public int jumpPower = 5;
	public float moveDelta;

	private int playerHealth = GameStatsTracker.PlayerStats.HealthPoints;


    // Update is called once per frame
    void Update()
    {
		MovePlayer();
		//CheckHealth();
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
		if(facingRight == true && )
		{

		}
		//CHARACTER DIRECTION
		//PHYSICS
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2((moveDelta * moveSpeed), gameObject.GetComponent<Rigidbody2D>().velocity.y);


	}
	public void Jump()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,5f), ForceMode2D.Impulse);
		Debug.Log(Vector2.up * jumpPower);
	}
	//void OnTriggerEnter2D(Collider2D other)
	//{
	//	Debug.Log("I tried to destroy something");
	//	Destroy(other.gameObject);
	//}
}
