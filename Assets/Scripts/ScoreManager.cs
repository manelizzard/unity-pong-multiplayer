using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Class handling the game scores. This scores
/// are not saved to disk nor synchronized to the cloud,
/// so their will be missed when the app is started again.
/// </summary>
public class ScoreManager : MonoBehaviour {

	private int playerOneScore;
	private int playerTwoScore;

	public GameObject scoreOneText;
	public GameObject scoreTwoText;

	void Start() {
		playerOneScore = 0;
		playerTwoScore = 0;
	}

	public void PlayerOneScores() {
		playerOneScore++;
		scoreOneText.GetComponent<Text>().text = playerOneScore.ToString ();
	}

	public void PlayerTwoScores() {
		playerTwoScore++;
		scoreTwoText.GetComponent<Text>().text = playerTwoScore.ToString ();
	}

	public int GetPlayerOneScore() {
		return playerOneScore;
	}

	public int GetPlayerTwoScore() {
		return playerTwoScore;
	}
}
