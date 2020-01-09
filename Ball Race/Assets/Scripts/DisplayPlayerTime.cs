using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerTime : MonoBehaviour
{
    [SerializeField]
    Text DisplayedText;

    void Start()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath + "/playerTime.dat", FileMode.Open);
        PlayerTime playerTime = bf.Deserialize(file) as PlayerTime;
        file.Close();

        DisplayedText.text = playerTime.time + "";
    }
}

