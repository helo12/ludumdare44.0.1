using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoother : MonoBehaviour
{
	public Vector3 cameraPos = Vector3.zero;
	public Transform target;
	// Start is called before the first frame update
	void FixedUpdate()
	{
		if (GameObject.FindWithTag("Player") != null)
		{
			cameraPos = new Vector3(
			Mathf.SmoothStep(transform.position.x, target.transform.position.x, 0.3f),
			Mathf.SmoothStep(transform.position.y + .5f, target.transform.position.y, 0.3f));
		}
	}

	// Update is called once per frame
	void LateUpdate()
	{
		if (GameObject.FindWithTag("Player") != null)
		{
			transform.position = cameraPos + Vector3.forward * -10;
		}
	}
}
