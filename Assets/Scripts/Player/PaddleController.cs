using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// Script implementing the base paddle behavior.
/// 
/// User can move the paddle up or down, depending on the child implementation.
/// </summary>
public abstract class PaddleController : NetworkBehaviour {

	public float speed = 5f;

	/// <summary>
	/// Limits the movement of the paddle upwards and downwards.
	/// </summary>
	public int maxField = 4;

	public void Update () {
		// - Only move if it is network local player
		if (!isLocalPlayer) {
			return;
		}

		// - Compute field limits
		this.transform.position = new Vector3 (transform.position.x,
			Mathf.Clamp (transform.position.y, -maxField, maxField));
	}

	protected void MoveUp() {
		// - Only move if it is network local player
		if (!isLocalPlayer) {
			return;
		}

		// - Move up
		transform.Translate(new Vector3(0f, speed * Time.deltaTime));
	}

	protected void MoveDown() {
		// - Only move if it is network local player
		if (!isLocalPlayer) {
			return;
		}

		// - Move down
		transform.Translate(new Vector3(0f, -speed * Time.deltaTime));
	}
}

