using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slice : MonoBehaviour {

    public int id;
	public Color color;
    public float wheelPercent;
    private Image img;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    private void Update()
    {
        img.color = color;
        img.fillAmount = wheelPercent;
    }
}
