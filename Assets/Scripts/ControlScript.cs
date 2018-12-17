using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xAxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float yAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		transform.Translate(xAxis, yAxis, 0);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log("collided with bullet (hopefully)", this);
	}

	// void OnTriggerStay2D (Collider2D other)
	// {
	// 	Debug.Log("collided with bullet (hopefully)", this);
	// }

	// void OnCollisionStay2D (Collision2D other)
	// {
	// 	Debug.Log("collided with bullet (hopefully)", this);
	// }

}
