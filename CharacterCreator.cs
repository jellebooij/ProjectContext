using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour {
	public ColorPicker colorPicker;
	public Popup creatorPopup;
	public PlayerList list;
	public PopupManager manager;
	public InputField playerName;
	public PlayerDisplay display;



	void Start () {
		display.UpdateList();

	}

	public void OpenCreator(){
		manager.OpenPopup(creatorPopup);
		playerName.text = "";
	}

	public void CloseCreator(){
		manager.ClosePopups();
	}
	
	public void CreateCharacter () {
		
		Player player = new Player();
		player.playerName = playerName.text;
		player.color = colorPicker.colors[colorPicker.TakeColor()];
		list.players.Add(player);

		display.UpdateList();

		manager.ClosePopups();
	}

	public void RemoveCharacter(int index){
		list.players.RemoveAt(index);
		display.UpdateList();
	}
}
