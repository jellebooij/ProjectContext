using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public PickPlayer playerPicker;
	public PickChallange challangePicker;
	public PopupManager popupManager;


	public PlayerCouple couple;
	Challange challange;

	void Start() {
		
		popupManager.Reset();
		StartCoroutine(GameLoop()); 

	}

	IEnumerator GameLoop(){

		while(true){

			playerPicker.Open();
			yield return new WaitUntil(() => playerPicker.ready == true);
			couple = playerPicker.couple;

			challangePicker.Open();
			yield return new WaitUntil(() => challangePicker.ready == true);
			challange = challangePicker.challange;


		}
	}
}
