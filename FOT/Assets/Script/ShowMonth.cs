using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ShowMonth : MonoBehaviour {

    Text Month;
    public int month;

	// Use this for initialization
	void Start () {
        Month = GetComponent<Text>();
        month = DateTime.Now.Month;
        Month.text = month.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
