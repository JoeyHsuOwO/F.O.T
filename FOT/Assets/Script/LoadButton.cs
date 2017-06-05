using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class LoadButton : MonoBehaviour {

    public GameObject content;
    public GameObject liveButton;
    public float livefeedItemHeight;
    public float livefeedItemWidth;
    public int Count = 1;
    public Vector3 distance;
    public RectTransform _rect; 
    public GameObject[] _Cloth;
    public static int ChooseNum;
    public static string _HatInfo;
    public static string _OnePieceInfo;
    public static string _TopInfo;
    public static string _PantInfo;
    public static string _SkirtInfo;
    public static string _ShoesInfo;
    public static string _SocksInfo;
    public static string _BagInfo;
    public static string _AccessoriesInfo;
    public static string _OtherInfo;

    // Use this for initialization
    void Start()
    {
        distance.x = 0;
        distance.y = -240;
        distance.z = 0;

        StartCoroutine(LoadPic(BuildCloth.WhichBuild));
    }


    IEnumerator LoadPic(int Cloth)
    {
        if (Cloth == 0)
        {
            _Cloth[0].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Hat", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgHat(i);
            }
        }
        else if (Cloth == 1)
        {
            _Cloth[1].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/OnePiece", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgOnePiece(i);
            }
        }

        else if (Cloth == 2)
        {
            _Cloth[2].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Top", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgTop(i);
            }
        }
        else if (Cloth == 3)
        {
            _Cloth[3].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Pant", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgPant(i);
            }

        }
        else if (Cloth == 4)
        {
            _Cloth[4].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Skirt", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgSkirt(i);
            }
        }
        else if (Cloth == 5)
        {
            _Cloth[5].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Shoes", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgShoes(i);
            }
        }
        else if (Cloth == 6)
        {
            _Cloth[6].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Socks", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgSocks(i);
            }
        }
        else if (Cloth == 7)
        {
            _Cloth[7].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Bag", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgBag(i);
            }
        }
        else if (Cloth == 8)
        {
            _Cloth[8].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Accessories", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgAccessories(i);
            }
        }
        else if (Cloth == 9)
        {
            _Cloth[9].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Other", "*.png", SearchOption.AllDirectories).Length;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgOther(i);
            }
        }

        yield return null;
    }
    public void AddImgHat(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Hat/" + "Hat" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgOnePiece(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/OnePiece/" + "OnePiece" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgTop(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Top/" + "Top" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgPant(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Pant/" + "Pant" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgSkirt(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Skirt/" + "Skirt" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgBag(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Bag/" + "Bag" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgShoes(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Shoes/" + "Shoes" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgSocks(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Socks/" + "Socks" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgAccessories(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Accessories/" + "Accessories" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgOther(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(liveButton) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath + "/Other/" + "Other" + fileNO + ".png";
        tempFeedItem.GetComponentInChildren<Text>().text = loadFolder;
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }

}
