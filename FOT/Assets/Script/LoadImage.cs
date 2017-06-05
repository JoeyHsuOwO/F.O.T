using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour {

    public GameObject content;
    public GameObject livefeedPrefab;
    public float livefeedItemHeight;
    public float livefeedItemWidth;
    public GameObject[] _Cloth;
    Texture2D[] _Images;
    //public  Image     feedtemplete;
    public int Count = 1;
    public Vector3 distance;
    public RectTransform _rect;

    // Use this for initialization
    void Start()
    {
        distance.x = 0;
        distance.y = -240;
        distance.z = 0;
        
        StartCoroutine(LoadPic(ChooseCloth.Choose));
        Debug.Log(ChooseCloth.Choose);
    }

    IEnumerator LoadPic(int Cloth)
    {
        if (Cloth == 0)
        {
            _Cloth[0].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/Hat", "*.png", SearchOption.AllDirectories).Length;
            PhoneCamera.count = Count;
            _rect.sizeDelta = new Vector2(822, 300 * (Count / 3));
            for (int i = 0; i < Count; i++)
            {
                AddImgHat(i);
            }
        }            
        else if(Cloth == 1)
        {
            _Cloth[1].SetActive(true);
            Count = Directory.GetFiles(Application.persistentDataPath + "/OnePiece", "*.png", SearchOption.AllDirectories).Length;
            PhoneCamera.count1 = Count;
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
            PhoneCamera.count2 = Count;
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
            PhoneCamera.count3 = Count;
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
            PhoneCamera.count4 = Count;
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
            PhoneCamera.count5 = Count;
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
            PhoneCamera.count6 = Count;
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
            PhoneCamera.count7 = Count;
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
            PhoneCamera.count8 = Count;
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
            PhoneCamera.count9 = Count;
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
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgOnePiece(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgTop(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
        tempFeedItem.name = "feeditem" + index;

        int fileNO = index;
        int widthindex = index % 3;
        int heightindex = index / 3;
        tempFeedItem.transform.parent = content.transform;
        tempFeedItem.transform.localPosition = new Vector3(livefeedItemWidth + -livefeedItemWidth * widthindex, -livefeedItemHeight * heightindex, 0.0f);
        tempFeedItem.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        GameObject newImageobject = tempFeedItem;
        RawImage newImage = newImageobject.GetComponent<RawImage>();


        string loadFolder = Application.persistentDataPath +"/Top/" + "Top" + fileNO + ".png";
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgPant(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgSkirt(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgBag(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgShoes(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgSocks(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgAccessories(int index)
    {
        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
    public void AddImgOther(int index)
    {

        Texture2D newTexture = null;
        byte[] fileData;
        GameObject tempFeedItem = Instantiate(livefeedPrefab) as GameObject;
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
        fileData = File.ReadAllBytes(loadFolder);
        newTexture = new Texture2D(720, 1000);
        newTexture.LoadImage(fileData);
        newImage.texture = newTexture;
    }
}
