using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class BuildCloth : MonoBehaviour {

    public static int WhichBuild = -1;
    public static int DontShow = 0;
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

        if(LoadButton._HatInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Hat.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._HatInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._OnePieceInfo != null)
        {
            _Top.SetActive(false);
            _Onepiece.SetActive(true);
            _Skirt.SetActive(false);
            _Pant.SetActive(false);
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Onepiece.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._OnePieceInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(500, 500);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._TopInfo != null)
        {
            _Onepiece.SetActive(false);
            _Top.SetActive(true);
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Top.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._TopInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(300, 300);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._PantInfo != null)
        {
            _Pant.SetActive(true);
            _Skirt.SetActive(false);
            _Onepiece.SetActive(false);
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Pant.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._PantInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(300, 300);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._SkirtInfo != null)
        {
            _Skirt.SetActive(true);
            _Pant.SetActive(false);
            _Onepiece.SetActive(false);
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Skirt.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._SkirtInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(300, 300);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._ShoesInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Shoes.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._ShoesInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._SocksInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Socks.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._SocksInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._BagInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Bag.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._BagInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._AccessoriesInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Accessories.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._AccessoriesInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }
        if (LoadButton._OtherInfo != null)
        {
            Texture2D newTexture = null;
            byte[] fileData;
            RawImage newImage = _Other.GetComponent<RawImage>();
            string loadFolder = null;
            loadFolder = LoadButton._OtherInfo;
            fileData = File.ReadAllBytes(loadFolder);
            newTexture = new Texture2D(150, 150);
            newTexture.LoadImage(fileData);
            newImage.texture = newTexture;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoBack()
    {
        WhichBuild = -1;
        DontShow = 0;
        LoadButton._AccessoriesInfo = null;
        LoadButton._BagInfo = null;
        LoadButton._HatInfo = null;
        LoadButton._OnePieceInfo = null;
        LoadButton._OtherInfo = null;
        LoadButton._PantInfo = null;
        LoadButton._ShoesInfo = null;
        LoadButton._SkirtInfo = null;
        LoadButton._SocksInfo = null;
        LoadButton._TopInfo = null;
        SceneManager.LoadScene(1);
    }

    public void ChooseHat()
    {
        WhichBuild = 0;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }

    public void ChooseOnePiece()
    {
        WhichBuild = 1;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseTop()
    {
        WhichBuild = 2;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChoosePant()
    {
        WhichBuild = 3;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseSkirt()
    {
        WhichBuild = 4;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseShoes()
    {
        WhichBuild = 5;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseSocks()
    {
        WhichBuild = 6;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseBag()
    {
        WhichBuild = 7;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseAccessories()
    {
        WhichBuild = 8;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
    public void ChooseOther()
    {
        WhichBuild = 9;
        DontShow = 1;
        SceneManager.LoadScene(7);
    }
}
