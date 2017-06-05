using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FunctionButton : MonoBehaviour {

    public GameObject leaveScreen;
    public bool leave;
    public int nowScene = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (leave)
            {
                leaveScreen.SetActive(false);
                leave = false;
            }
            else
            {
                leaveScreen.SetActive(true);
                leave = true;
            }
        }

    }

    public void ChooseFestival()
    {
        SceneManager.LoadScene(2);
    }

    public void ChooseCalendar()
    {
        SceneManager.LoadScene(1);
    }

    public void ChooseWardorbe()
    {
        SceneManager.LoadScene(3);
    }

}
