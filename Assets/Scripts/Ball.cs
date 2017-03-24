using UnityEngine;
using System.Collections;

/// <summary>
/// Script handling the ball behavior. When user press "SPACE" key, 
/// the ball is applied a random force in order to move.
/// 
/// If the ball collides with a "Respawn" tag collider, the forces
/// are removed and the ball is moved to the center of the scene.
/// </summary>
public class Ball : MonoBehaviour {

	private bool started = false;
	private Rigidbody2D rigidBody;
	private ScoreManager scoreManager;

	void Start () {
		scoreManager = FindObjectOfType<ScoreManager> ();
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (!started) {

			if (Input.GetKeyDown (KeyCode.Space)) {
				// - Start game
				started = true;
				rigidBody.velocity = new Vector2 (Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(5f, 8f), 
					Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(5f, 8f));
			}
		}
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
