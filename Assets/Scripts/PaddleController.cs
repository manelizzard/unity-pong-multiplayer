using UnityEngine;
using System.Collections;

/// <summary>
/// Script implementing the paddle behavior.
/// 
/// User can move the paddle up with "W" key or down with "S" key.
/// </summary>
public class PaddleController : MonoBehaviour {

	public float speed = 1f;

	/// <summary>
	/// Limits the movement of the paddle upwards and downwards.
	/// </summary>
	public int maxField = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.W)) {
			// - Move up
			transform.Translate(new Vector3(0f, speed * Time.deltaTime));
		} else if(Input.GetKey(KeyCode.S)) {
			// - Move down
			transform.Translate(new Vector3(0f, -speed * Time.deltaTime));
		}

		// - Compute field limits
		this.transform.position = new Vector3 (transform.position.x,
			Mathf.Clamp (transform.position.y, -maxField, maxField));
	}
}
