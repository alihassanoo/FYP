//----------------------------------------------
//           	   Highway Racer
//
// Copyright © 2014 - 2017 BoneCracker Games
// http://www.bonecrackergames.com
//
//----------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HR_GameOverPanel : MonoBehaviour {

	public GameObject content;

	[Header("UI Texts On Scoreboard")]
	public Text totalScore;

	public Text totalDistance;
	public Text totalNearMiss;
	public Text totalOverspeed;
	public Text totalOppositeDirection;

	
	

	void OnEnable(){

		HR_PlayerHandler.OnPlayerDied += HR_PlayerHandler_OnPlayerDied;

	}

	void HR_PlayerHandler_OnPlayerDied (HR_PlayerHandler player){

		StartCoroutine (DisplayResults(player));
		
	}

	public IEnumerator DisplayResults(HR_PlayerHandler player){

		yield return new WaitForSecondsRealtime (1f);

		content.SetActive (true);

		totalScore.text = Mathf.Floor(player.score).ToString("F0");
		totalDistance.text = (player.distance).ToString("F2");
		totalNearMiss.text = (player.nearMisses).ToString("F0");
		totalOverspeed.text = (player.highSpeedTotal).ToString("F1");

		


		gameObject.BroadcastMessage("Animate");
		gameObject.BroadcastMessage("GetNumber");

	}

	void OnDisable(){

		HR_PlayerHandler.OnPlayerDied -= HR_PlayerHandler_OnPlayerDied;

	}

}
