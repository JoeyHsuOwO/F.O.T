using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ShowYear : MonoBehaviour {

    Text Year;
    public int year;

    // Use this for initialization
    void Start()
    {
        Year = GetComponent<Text>();
        year = DateTime.Now.Year;
        Year.text = year.ToString();

    }

    // Update is called once per frame
    void Update () {
	
	}
}
