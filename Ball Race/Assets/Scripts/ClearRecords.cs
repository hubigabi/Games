using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class ClearRecords : MonoBehaviour
{
    [SerializeField]
    Text DisplayedText;

    public void Clear() {
        Record record = new Record(999.99, 999.99, 999.99);
        File.WriteAllText(Application.dataPath + "/records.dat", String.Empty);

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fileStream = new FileStream(Application.dataPath + "/records.dat",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

        bf.Serialize(fileStream, record);
        fileStream.Close();
        Debug.Log("Cleared");

        DisplayedText.text = "1:  " + record.record1 + "\n"
            + "2:  " + record.record2 + "\n"
            + "3:  " + record.record3 + "\n";

    }

}
