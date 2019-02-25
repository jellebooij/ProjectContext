using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {

	public PlayerList list;
	public Image[] borders;
	public Image[] avatars;
	public Text[] names;
	public GameObject[] players;

	private void Awake() {
		list.players.Clear();
	}

	public void UpdateList () {

		for(int i = 0; i < 8; i++){
			players[i].SetActive(false);
		}

		for(int i = 0; i < list.players.Count; i++){
			players[i].SetActive(true);
			names[i].text = list.players[i].playerName;
			borders[i].color = list.players[i].color;
		}


	}
}
