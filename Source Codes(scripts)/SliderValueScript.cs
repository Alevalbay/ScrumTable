using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueScript : MonoBehaviour {
    Text PercentText;
	// Use this for initialization
	void Start () {
        PercentText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	public void textuptade (float value)
    { PercentText.text = Mathf.RoundToInt(value) + "%";
    }
}
