using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Scenes { Menu, CharacterSelect, InGame, EndScreen }

public class CanvasManager : MonoBehaviour {

	public GameObject[] scenes;
	public Scenes startScene;

	private void Start() {

		SwitchScene((int)startScene);

	}

	public void SwitchScene(int scene){

		for(int i = 0; i < scenes.Length; i++){
			scenes[i].SetActive(false);
		}

		scenes[scene].SetActive(true);

	}

}
