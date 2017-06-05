using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

public class ScreenShot : MonoBehaviour {

    public RawImage _raw;
    public GameObject _Hat;
    public GameObject _Top;
    public GameObject _Pant;
    public GameObject _Shoes;
    public GameObject _Socks;
    public GameObject _Bag;
    public GameObject _Accessories;
    public GameObject _Other;
    public GameObject _Onepiece;
    public GameObject _Skirt;

    // Use this for initialization
    void Start () {

        if(System.IO.File.Exists(Application.persistentDataPath + "/MyCloth/" + DateButton.year + "_" + DateButton.month + "_" + DateButton.day + ".png") && BuildCloth.DontShow != 1)
        {
            _Hat.SetActive(false);
            _Top.SetActive(false);
            _Onepiece.SetActive(false);
            _Skirt.SetActive(false);
            _Pant.SetActive(false);
            _Shoes.SetActive(false);
            _Socks.SetActive(false);
            _Bag.SetActive(false);
            _Accessories.SetActive(false);
            _Other.SetActive(false);
            Texture2D newTexture = null;
            byte[] fileData;
            fileData = File.ReadAllBytes(Application.persistentDataPath + "/MyCloth/" + DateButton.year + "_" + DateButton.month + "_" + DateButton.day + ".png");
            newTexture = new Texture2D(800, 1200);
            newTexture.LoadImage(fileData);
            _raw.texture = newTexture;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GetScreenShot()
    {
        StartCoroutine(GetScreen());
    }

    IEnumerator GetScreen()
    {
        yield return new WaitForEndOfFrame();

        var tex = new Texture2D(Screen.width,Screen.height-600, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 420, Screen.width, (Screen.height - 600)), 0, 0);
        tex.Apply();

        var bytes = tex.EncodeToPNG();
        Destroy(tex);

        File.WriteAllBytes(Application.persistentDataPath + "/MyCloth/" + DateButton.year + "_" + DateButton.month + "_" + DateButton.day + ".png", bytes);
    }

    public void CancelButton()
    {
        _raw.texture = null;
        _Hat.GetComponent<RawImage>().texture = null;
        _Onepiece.GetComponent<RawImage>().texture = null;
        _Top.GetComponent<RawImage>().texture = null;
        _Pant.GetComponent<RawImage>().texture = null;
        _Skirt.GetComponent<RawImage>().texture = null;
        _Shoes.GetComponent<RawImage>().texture = null;
        _Socks.GetComponent<RawImage>().texture = null;
        _Bag.GetComponent<RawImage>().texture = null;
        _Accessories.GetComponent<RawImage>().texture = null;
        _Other.GetComponent<RawImage>().texture = null;
        _Hat.SetActive(true);
        _Onepiece.SetActive(true);
        _Top.SetActive(true);
        _Pant.SetActive(true);
        _Skirt.SetActive(true);
        _Shoes.SetActive(true);
        _Socks.SetActive(true);
        _Bag.SetActive(true);
        _Accessories.SetActive(true);
        _Other.SetActive(true);
        LoadButton._HatInfo = null;
        LoadButton._OnePieceInfo = null;
        LoadButton._TopInfo = null;
        LoadButton._PantInfo = null;
        LoadButton._SkirtInfo = null;
        LoadButton._ShoesInfo = null;
        LoadButton._SocksInfo = null;
        LoadButton._BagInfo = null;
        LoadButton._AccessoriesInfo = null;
        LoadButton._OtherInfo = null;
    }



}
