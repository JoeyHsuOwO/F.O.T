using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DateButton : MonoBehaviour {

    public static int day;
    public static int year;
    public static int month;
    private Text _text;
    public Text _month;
    private Text _day;
    public Text _year;
    private Button _button;
    private string _textint;


    // Use this for initialization
    void Start () {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Task);
        _text = GetComponentInParent<Text>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Task()
    {
        _day = GetComponentInParent<Text>();
        _textint = _day.text.ToString();
        int.TryParse(_textint, out day);
        if (day >= 1)
        {                      
            int.TryParse(_year.text.ToString(), out year);
            int.TryParse(_month.text.ToString(), out month);
            SceneManager.LoadScene(4);
        }
        else
            return;
    }

}
