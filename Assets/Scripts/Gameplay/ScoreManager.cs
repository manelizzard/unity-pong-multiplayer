using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

/// <summary>
/// Class handling the game scores. 
/// 
/// This scores are multiplayer synchronized via SyncVar.
/// </summary>
public class ScoreManager : NetworkBehaviour {

	[SyncVar(hook="UpdateScoreOne")]
	private int playerOneScore;

	[SyncVar(hook="UpdateScoreTwo")]
	private int playerTwoScore;

	public GameObject scoreOneText;
	public GameObject scoreTwoText;

	void Start() {
		playerOneScore = 0;
		playerTwoScore = 0;
	}

	public void PlayerOneScores() {
		UpdateScoreOne (++playerOneScore);
	}

	public void PlayerTwoScores() {
		UpdateScoreTwo (++playerTwoScore);
	}

	public void UpdateScoreOne(int value) {
		scoreOneText.GetComponent<Text>().text = value.ToString ();
	}

	public void UpdateScoreTwo(int value) {
		scoreTwoText.GetComponent<Text>().text = value.ToString ();
	}

	public int GetPlayerOneScore() {
		return playerOneScore;
	}

	public int GetPlayerTwoScore() {
		return playerTwoScore;
	}
}
