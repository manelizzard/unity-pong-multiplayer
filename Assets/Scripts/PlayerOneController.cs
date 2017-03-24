using UnityEngine;
using System.Collections;

/// <summary>
/// Player one controlls the paddle with "W" and "S" keys
/// </summary>
public class PlayerOneController : PaddleController {
	
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			// - Move up
			MoveUp();
		} else if(Input.GetKey(KeyCode.S)) {
			// - Move down
			MoveDown();
		}
	}
}
