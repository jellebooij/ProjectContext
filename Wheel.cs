using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wheel : MonoBehaviour {

	[SerializeField]
	float wheelRotation;

	[SerializeField]
	Image slicePrefab;

	[SerializeField]
	float maxRotationSpeed;

	[SerializeField]
	float decelerationTime;

	[SerializeField]
	bool clockWise;

	List<Image> slices = new List<Image>();

	float rotationSpeed;
	public bool spinning;

	public void AddSlice(Color sliceColor){

		Image slice = Instantiate(slicePrefab, transform.position, Quaternion.identity, transform);
		slice.color = sliceColor;
		slices.Add(slice);
			
	}

	public void RemoveLastSlice(){
		
		Image lastImage = slices[slices.Count - 1];

		slices.Remove(lastImage);
		Destroy(lastImage.gameObject);

	}

	public void Refresh(){

		for(int i = 0; i < slices.Count; i++){

			slices[i].fillAmount = 1.0f / slices.Count;
			slices[i].gameObject.transform.localEulerAngles = new Vector3(0, 0, 360 - ((360 / slices.Count) * i));

		}
	}

	public void Clear(){

		for(int i = 0; i < slices.Count; i++){
			RemoveLastSlice();
		}
		
		Refresh();

	}

	public void Spin(){

		rotationSpeed = maxRotationSpeed;
		spinning = true;
		StartCoroutine(SpinWheel());

	}



	public int GetCurrentSlice(){

		if(slices.Count > 0)
			return (int)(wheelRotation / (360 / slices.Count));
		else 
			return -1;
		
	}

	IEnumerator SpinWheel(){

		while(rotationSpeed > 0){
			
			wheelRotation += rotationSpeed * Time.deltaTime * ((clockWise) ? 1 : -1);
			wheelRotation = wheelRotation % 360;		
			
			if(wheelRotation < 0){
				wheelRotation = 360 + wheelRotation;
			}
			
			transform.eulerAngles = new Vector3(0, 0, wheelRotation);
			
			rotationSpeed -= Time.deltaTime * 1 / decelerationTime * maxRotationSpeed; 

			if(rotationSpeed < 0.1f){
				rotationSpeed = 0;
				spinning = false;
				yield break;
			}
			
			yield return null;
		}	
	}
}
