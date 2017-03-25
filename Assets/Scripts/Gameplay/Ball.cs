using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// Script handling the ball behavior.
/// 
/// If the ball collides with a "Respawn" tag collider, the forces
/// are removed and the ball is moved to the center of the scene.
/// </summary>
public class Ball : NetworkBehaviour {

	private bool started = false;
	private Rigidbody2D rigidBody;
	private ScoreManager scoreManager;
	private PongNetworkManager networkManager;

	void Start () {
		scoreManager = FindObjectOfType<ScoreManager> ();
		rigidBody = GetComponent<Rigidbody2D> ();
		networkManager = FindObjectOfType<PongNetworkManager> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "PlayerOneGoal") {
			Respawn ();
			scoreManager.PlayerTwoScores ();
		} else if (col.gameObject.tag == "PlayerTwoGoal") {
			Respawn ();
			scoreManager.PlayerOneScores ();
		}
	}

	private void Respawn() {
		// - If a lose collider has been hit, respawn the ball.
		started = false;
		this.transform.position = new Vector2 (0f, 0f);
		rigidBody.velocity = Vector2.zero;
	}
}
