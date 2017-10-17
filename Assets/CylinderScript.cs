using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
	private bool moving = false;
	private float turnSpeed = 30f;
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.Escape))
			Application.Quit();

		if (moving == false && Input.GetKey(KeyCode.Space))
			moving = true;
		else if (moving = true)
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
	}
}
