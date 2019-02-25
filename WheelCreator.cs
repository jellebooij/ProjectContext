using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelCreator : MonoBehaviour {

	public Wheel[] playerWheel;
	public Wheel challangeWheel;

	public Color[] challangeSlices;

	public PlayerList list;

	void Start(){
		CreateWheels(list);
	}
	public void CreateWheels(PlayerList list){
		
		for(int i = 0; i < playerWheel.Length; i++){

			playerWheel[i].Clear();

			for(int j = 0; j < list.players.Count; j++){
				playerWheel[i].AddSlice(list.players[j].color);
			}

			playerWheel[i].Refresh();

		}

		for(int i = 0; i < challangeSlices.Length; i++){
			challangeWheel.AddSlice(challangeSlices[i]);
		}

		challangeWheel.Refresh();


	}
}
