using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	public delegate void UpdatePos(BulletScript updateBullet);
	public UpdatePos updatePos;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		updatePos(this);
	}
}
