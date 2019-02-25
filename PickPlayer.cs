using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct PlayerCouple{
    public Player player1;
    public Player player2;
    public PlayerCouple(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }
}

public class PickPlayer : MonoBehaviour {

	public PlayerList list;
	public PopupManager popupManager;
	public Wheel player1;
	public Wheel player2;
	public Popup playerPicker;
	public PlayerCouple couple;
	public bool ready;
	bool popupsOpen;
	bool wheelsSpun;
	

	public void Open(){

		popupManager.ClosePopups();
		popupManager.OpenPopup(playerPicker);

		ready = false;
		wheelsSpun = false;
		popupsOpen = true;

	}
	private void Update() {
		
		if(popupsOpen){

			if(Input.GetMouseButtonDown(0)){

				player1.Spin();
				player2.Spin();
				wheelsSpun = true;

			}

			if(wheelsSpun && !ready && !player1.spinning && !player2.spinning){

				couple = new PlayerCouple(list.players[player1.GetCurrentSlice()], list.players[player2.GetCurrentSlice()]);
				ready = true;
				popupsOpen = false;

			}
		}
	}
}
