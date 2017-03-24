using UnityEngine;
using System.Collections;

/// <summary>
/// Script implementing the base paddle behavior.
/// 
/// User can move the paddle up or down, depending on the child implementation.
/// </summary>
public abstract class PaddleController : MonoBehaviour {

	public float speed = 1f;

	/// <summary>
	/// Limits the movement of the paddle upwards and downwards.
	/// </summary>
	public int maxField = 4;
	
	// Update is called once per frame
	void Update () {
		// - Compute field limits
		this.transform.position = new Vector3 (transform.position.x,
			Mathf.Clamp (transform.position.y, -maxField, maxField));
	}

	protected void MoveUp() {
		// - Move up
		transform.Translate(new Vector3(0f, speed * Time.deltaTime));
	}

	protected void MoveDown() {
		// - Move down
		transform.Translate(new Vector3(0f, -speed * Time.deltaTime));
	}
}

