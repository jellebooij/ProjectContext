using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PopupManger", menuName = "DrinkingWild/PopupManger", order = 0)]
public class PopupManager : ScriptableObject {

	private List<Popup> openPopups = new List<Popup>();

	public void OpenPopup(Popup popup){

		openPopups.Add(popup);
		popup.gameObject.SetActive(true);
		popup.Open();

	}

	public void ClosePopups(){

		Debug.Log(openPopups.Count);

		for(int i = 0; i < openPopups.Count; i++){

			openPopups[i].Close();
	
		}
		
		openPopups.Clear();

	}

	public void Reset(){

		Debug.Log(openPopups.Count);

	}


}
