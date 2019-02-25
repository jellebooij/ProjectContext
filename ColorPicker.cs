using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour {

	public Sprite grey;
	public Transform checkMark;
	public Transform[] colorPositions;
	public Color[] colors;
	public Image[] colorImages;
	public Sprite[] colorSprites;
	bool[] colorTaken = new bool[8];
	int currentColor;


	private void OnEnable() {
		
		for(int i = 0; i < 8; i++){
			if(!colorTaken[i]){
				ChangeSelection(i);
				break;
			}
		}
	
		
	}
	
	public int TakeColor(){
		colorTaken[currentColor] = true;
		colorImages[currentColor].sprite = grey;
		return currentColor;
	}

	public void MakeColorAvailable(int color){
		colorTaken[color] = false;
		colorImages[currentColor].sprite = colorSprites[color];
	}

	public void ChangeSelection(int color) {
		if(!colorTaken[color]){
			currentColor = color;
			checkMark.position = colorPositions[color].position;
		}
	}
}
