using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PongNetworkManager : NetworkManager {

	private bool isHost = false;

	void Update() {

		if (CanStartGame() && Input.GetKeyDown (KeyCode.Space)) {
			// - Start game
			GameObject ball = FindObjectsOfType<Ball>().Length > 0 ? FindObjectsOfType<Ball>()[0].gameObject as GameObject: null;
			if (ball == null) {
				ball = Instantiate (spawnPrefabs [0], Vector2.zero, Quaternion.identity) as GameObject;
				NetworkServer.Spawn (ball);
			}

			// - Apply a force to the ball to start moving
			ball.GetComponent<Rigidbody2D>().velocity = new Vector2 (Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(4f, 6f), 
				Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(4f, 6f));
		}
	}

	/// <summary>
	/// Determines whether the game can be started or not. Two clients connected it's a must. 
	/// Only host can start the game.
	/// 
	/// TODO: Implement a turn-based game start.
	/// </summary>
	/// 
	/// <returns><c>true</c> if the game can start; otherwise, <c>false</c>.</returns>
	private bool CanStartGame() {
		return NetworkServer.connections.Count == 2 && isHost;
	}

	public override void OnStartHost () {
		base.OnStartHost ();
		isHost = true;
	}

	public void OnGUI() {
		GUILayout.Label ("Client connections " + NetworkServer.connections.Count + "/2");
	}
}
