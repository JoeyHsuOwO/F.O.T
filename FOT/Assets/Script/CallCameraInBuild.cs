using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CallCameraInBuild : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ChangeToCamera()
    {
        SceneManager.LoadScene(6);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(4);
    }
}
