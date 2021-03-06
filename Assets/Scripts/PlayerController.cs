﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

	bool wonLevel = false;


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
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,5f), ForceMode2D.Impulse);
		Debug.Log(Vector2.up * jumpPower);
	}

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Win")
		{
				
				SceneManager.LoadScene(GameStatsTracker.PlayerStats.Level.ToString(), LoadSceneMode.Additive);

			//switch (caseSwitch)
			//{
			//	case 1:
			//		Console.WriteLine("Case 1");
			//		break;
			//	case 2:
			//		Console.WriteLine("Case 2");
			//		break;
			//	default:
			//		Console.WriteLine("Default case");
			//		break;
			//}
		}
		else
		{
			Debug.Log("I did nothing:)");
		}
	}
}
