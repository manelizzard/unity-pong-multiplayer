using UnityEngine;
using System.Collections;

/// <summary>
/// Player two controlls the paddle with the arrows
/// </summary>
public class PlayerTwoController : PaddleController {

	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			MoveUp();
		} else if(Input.GetKey(KeyCode.DownArrow)) {
			MoveDown();
		}
	}
}
