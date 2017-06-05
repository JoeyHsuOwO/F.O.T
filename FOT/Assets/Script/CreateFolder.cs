using UnityEngine;
using System.Collections;
using System.IO;

public class CreateFolder : MonoBehaviour
{

    void Start()
    {
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
        if (!Directory.Exists(Application.persistentDataPath + "/MyCloth"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/MyCloth");
        }
    }

}
