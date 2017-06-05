using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;

public class PhoneCamera : MonoBehaviour {

    public  WebCamTexture mCamera = null;
    public GameObject plane;
    public GameObject g;
    private Texture2D texture1;
    private Texture2D texture2;
    public static int count = 0;
    public static int count1 = 0;
    public static int count2 = 0;
    public static int count3 = 0;
    public static int count4 = 0;
    public static int count5 = 0;
    public static int count6 = 0;
    public static int count7 = 0;
    public static int count8 = 0;
    public static int count9 = 0;
    public GameObject SaveButton;
    public GameObject PictureButton;
    public bool SaveorNot;

    // Use this for initialization
    void Start () {
        if (!Directory.Exists(Application.persistentDataPath + "/Hat"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Hat");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/OnePiece"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/OnePiece");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Top"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Top");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Pant"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Pant");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Skirt"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Skirt");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Bag"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Bag");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Shoes"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Shoes");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Socks"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Socks");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Accessories"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Accessories");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/Other"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/Other");
        }
        plane = GameObject.FindWithTag("Player");

        mCamera = new WebCamTexture();
        plane.GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();
        SaveButton.SetActive(false);
        PictureButton.SetActive(true);
        g.SetActive(false);
    }

    public Texture2D heightmap;


    public void TakePicture()
    {
        StartCoroutine(ScreenshotEncode());
        
    }

    public void SavePicture()
    {
        if(ChooseCloth.Choose == 0)
        {
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Hat/Hat" + count + ".png", bytes);
            count++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if(ChooseCloth.Choose == 1)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/OnePiece/OnePiece" + count1 + ".png"))
                {
                    count1++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/OnePiece/OnePiece" + count1 + ".png", bytes);
            count1++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 2)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Top/Top" + count2 + ".png"))
                {
                    count2++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Top/Top" + count2 + ".png", bytes);
            count2++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 3)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Pant/Pant" + count3 + ".png"))
                {
                    count3++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Pant/Pant" + count3 + ".png", bytes);
            count3++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 4)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Skirt/Skirt" + count4 + ".png"))
                {
                    count4++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Skirt/Skirt" + count4 + ".png", bytes);
            count4++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 5)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Shoes/Shoes" + count5 + ".png"))
                {
                    count5++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Shoes/Shoes" + count5 + ".png", bytes);
            count5++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 6)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Socks/Socks" + count6 + ".png"))
                {
                    count6++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Socks/Socks" + count6 + ".png", bytes);
            count6++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 7)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Bag/Bag" + count7 + ".png"))
                {
                    count7++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Bag/Bag" + count7 + ".png", bytes);
            count7++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 8)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Accessories/Accessories" + count8 + ".png"))
                {
                    count8++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Accessories/Accessories" + count8 + ".png", bytes);
            count8++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }
        else if (ChooseCloth.Choose == 9)
        {
            while (true)
            {
                if (Directory.Exists(Application.persistentDataPath + "/Other/Other" + count9 + ".png"))
                {
                    count9++;
                }
                else
                    break;
            }
            byte[] bytes = texture1.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.persistentDataPath + "/Other/Other" + count9 + ".png", bytes);
            count9++;
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
        }

    }

    public IEnumerator ScreenshotEncode()
    {
        yield return new WaitForEndOfFrame();
        texture1 = new Texture2D(Screen.width, Screen.height - 400, TextureFormat.RGB24, false);
        texture1.ReadPixels(new Rect(0, 400, Screen.width, Screen.height), 0, 0);
        texture1.Apply();      
        SaveorNot = true;
        g.SetActive(true);
        g.GetComponent<Renderer>().material.mainTexture = texture1;
        SaveButton.SetActive(true);
        PictureButton.SetActive(false);
        yield return 0;       
    }

    public void GoBack()
    {
        if(SaveorNot == true)
        {
            g.SetActive(false);
            SaveButton.SetActive(false);
            PictureButton.SetActive(true);
            SaveorNot = false;
        }
        else if(SaveorNot == false && ChooseCloth.Choose != -1 && BuildCloth.WhichBuild == -1)
        {
            mCamera.Stop();
            SceneManager.LoadScene(5);
        }
        else if(SaveorNot == false && ChooseCloth.Choose == -1 && BuildCloth.WhichBuild != -1)
        {
            mCamera.Stop();
            SceneManager.LoadScene(7);
        }
    }
   
}
