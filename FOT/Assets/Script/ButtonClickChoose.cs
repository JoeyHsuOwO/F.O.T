using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickChoose : MonoBehaviour {


    private Button _button;
    private Text _text;
    private string Info;

	// Use this for initialization
	void Start () {

        _button = GetComponent<Button>();
        _button.onClick.AddListener(Task);
        _text = GetComponentInChildren<Text>();
        Info = _text.text;

    }
	
	// Update is called once per frame
	void Update () {

	}

    void Task()
    {
        if(BuildCloth.WhichBuild == 0)
        {
            LoadButton._HatInfo = Info;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 1)
        {
            LoadButton._OnePieceInfo = Info;
            if (LoadButton._TopInfo != null)
                LoadButton._TopInfo = null;
            if (LoadButton._SkirtInfo != null)
                LoadButton._SkirtInfo = null;
            if (LoadButton._PantInfo != null)
                LoadButton._PantInfo = null;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 2)
        {
            LoadButton._TopInfo = Info;
            if (LoadButton._OnePieceInfo != null)
                LoadButton._OnePieceInfo = null;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 3)
        {
            LoadButton._PantInfo = Info;
            if (LoadButton._SkirtInfo != null)
                LoadButton._SkirtInfo = null;
            if (LoadButton._OnePieceInfo != null)
                LoadButton._OnePieceInfo = null;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 4)
        {
            LoadButton._SkirtInfo = Info;
            if (LoadButton._PantInfo != null)
                LoadButton._PantInfo = null;
            if (LoadButton._OnePieceInfo != null)
                LoadButton._OnePieceInfo = null;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 5)
        {
            LoadButton._ShoesInfo = Info;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 6)
        {
            LoadButton._SocksInfo = Info;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 7)
        {
            LoadButton._BagInfo = Info;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 8)
        {
            LoadButton._AccessoriesInfo = Info;
            SceneManager.LoadScene(4);
        }
        if (BuildCloth.WhichBuild == 9)
        {
            LoadButton._OtherInfo = Info;
            SceneManager.LoadScene(4);
        }
    }

}
