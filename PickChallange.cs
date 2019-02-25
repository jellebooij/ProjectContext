using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickChallange : MonoBehaviour {

	public string[] challanges1;
	public string[] challanges2;
	public string[] challanges3;
	public string[] challanges4;
	public PopupManager popupManager;
	public Wheel wheel;
	public Popup challangePicker;
	public Challange challange;
	public bool ready;
	bool popupsOpen;
	bool wheelsSpun;
	

	public void Open(){

		popupManager.ClosePopups();
		popupManager.OpenPopup(challangePicker);

		ready = false;
		wheelsSpun = false;
		popupsOpen = true;

		Debug.Log("rddy");

	}
	private void Update() {
		
		if(popupsOpen){

			if(Input.GetMouseButtonDown(0)){

				wheel.Spin();
				wheelsSpun = true;

			}

			if(wheelsSpun && !ready && !wheel.spinning){

				int slice = wheel.GetCurrentSlice();

				challange.points = slice;

				if(slice == 0){
					challange.challange = challanges1[Random.Range(0,challanges1.Length)];
				}

				if(slice == 1){
					challange.challange = challanges2[Random.Range(0,challanges2.Length)];
				}

				if(slice == 2){
					challange.challange = challanges3[Random.Range(0,challanges3.Length)];
				}

				if(slice == 3){
					challange.challange = challanges4[Random.Range(0,challanges4.Length)];
				}

				ready = true;
				popupsOpen = false;
			}
		}
	}
}
