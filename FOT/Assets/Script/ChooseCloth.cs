using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseCloth : MonoBehaviour {

    static public int Choose = -1;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BackToCalendar()
    {
        Choose = -1;
        SceneManager.LoadScene(1);
    }

    public void ChangeSceneToHat()
    {
        Choose = 0;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToOnePiece()
    {
        Choose = 1;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToTop()
    {
        Choose = 2;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToPant()
    {
        Choose = 3;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToSkirt()
    {
        Choose = 4;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToShoes()
    {
        Choose = 5;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToSocks()
    {
        Choose = 6;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToBag()
    {
        Choose = 7;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToAccessories()
    {
        Choose = 8;
        SceneManager.LoadScene(5);
    }
    public void ChangeSceneToOther()
    {
        Choose = 9;
        SceneManager.LoadScene(5);
    }

}
