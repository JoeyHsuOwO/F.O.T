using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseMonth : MonoBehaviour {

    public GameObject[] _Month;
    public GameObject _MonthPage;
    public int _Choose;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Choose(int _month)
    {
        _MonthPage.SetActive(true);
        _Month[_month].SetActive(true);
        _Choose = _month;
    }

    public void ChooseBack()
    {
        _Month[_Choose].SetActive(false);
        _MonthPage.SetActive(false);
    }

    public void ChooseBackToCalendar()
    {
        SceneManager.LoadScene(1);
    }

}
