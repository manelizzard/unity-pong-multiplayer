using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/// <summary>
/// Player one controlls the paddle with "ARROW UP" and "ARROW DOWN" keys
/// </summary>
public class PlayerController : PaddleController {

	public void Update () {
		base.Update ();

		if (Input.GetKey (KeyCode.UpArrow)) {
			// - Move up
			MoveUp();
		} else if(Input.GetKey(KeyCode.DownArrow)) {
			// - Move down
			MoveDown();
		}
	}
}
