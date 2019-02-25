using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class Popup : MonoBehaviour {

	Vector3 refSize;
    bool closing;
    Vector3 startSize;
	public float popupSpeed;

    CanvasGroup group;

    private void Start() {
        group = GetComponent<CanvasGroup>();
    }

    public void Open() {

        transform.localScale = Vector3.zero;
        closing = false;

    }

    public void Close() {

        closing = true;

    }
	
	void Update() {
        
        

        if (closing == false)
        {
            transform.localScale = Vector3.SmoothDamp(transform.localScale, Vector3.one, ref refSize, popupSpeed);
            group.alpha = transform.localScale.x * 2;
        }
		else
        {
            transform.localScale = Vector3.SmoothDamp(transform.localScale, Vector3.zero, ref refSize, popupSpeed);
             group.alpha = transform.localScale.x / 1.2f;
        }

        if(transform.localScale.x < 0.1f && closing)
        {
            gameObject.SetActive(false);
        }

    }
}
