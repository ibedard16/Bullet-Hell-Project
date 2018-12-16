using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyScript : MonoBehaviour {
	public BulletScript bullet;
	public float direction;
	public int cooldown;

	// Use this for initialization
	void Start () {
		direction = 0;
		cooldown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown == 0) {
			for (int i = 0; i < 20; ++i) {
				var spawnedBullet = Instantiate(bullet);
				var velocity = new Vector3(Mathf.Cos(direction), Mathf.Sin(direction), 0);
				spawnedBullet.updatePos = (BulletScript updatingBullet) => {
					updatingBullet.transform.position +=  Time.deltaTime * velocity;
				};
				direction += 0.1f;
			}
			cooldown = 10;
		}
		cooldown -= 1;
	}
}
