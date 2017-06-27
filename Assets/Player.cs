using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject player;
	public double playerHealth = 3000;
	public float playerSpeed = 5.0f;
	private float playerFireRate = 0.09f;
	private float playerLastShot = 0.0f;
	public double pelletDamage = 0.05;
	public float pelletSpeed = 100.0f;

	public GameObject pellet;

	public Transform pelletTopSpawn;

	void FixedUpdate() {
		playerMovement ();
		playerShoot ();
	}

	void playerMovement() {
		if (Input.GetKey("w") || Input.GetKey("up")) {
			player.transform.Translate (Vector2.up * Time.deltaTime * playerSpeed);
		}
		if (Input.GetKey("s") || Input.GetKey("down")) {
			player.transform.Translate (Vector2.down * Time.deltaTime * playerSpeed);
		}
		if (Input.GetKey("a") || Input.GetKey("left")) {
			player.transform.Translate (Vector2.left * Time.deltaTime * playerSpeed);
		}
		if (Input.GetKey("d") || Input.GetKey("right")) {
			player.transform.Translate (Vector2.right * Time.deltaTime * playerSpeed);
		}
	}

	void playerShoot() {
		if (Input.GetKey("space") && Time.time > playerFireRate + playerLastShot) {
			GameObject shootUp = (GameObject)Instantiate (pellet, pelletTopSpawn.position, pelletTopSpawn.rotation);
			Rigidbody2D up = shootUp.GetComponent<Rigidbody2D> ();
			up.AddForce (Vector2.up * pelletSpeed);
			playerLastShot = Time.time;
		}
	}
}
