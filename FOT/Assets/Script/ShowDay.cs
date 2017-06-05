using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ShowDay : MonoBehaviour {

    Text Day;
    public int day;

    // Use this for initialization
    void Start()
    {
        Day = GetComponent<Text>();
        day = DateTime.Now.Day;
        Day.text = day.ToString();

    }

    // Update is called once per frame
    void Update () {
	
	}
}
