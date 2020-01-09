using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class DisplayRecords : MonoBehaviour
{
    Text DisplayedText;

    void Start()
    {
        DisplayedText = GetComponent<Text>();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.dataPath + "/records.dat", FileMode.Open);
        Record record = bf.Deserialize(file) as Record;
        file.Close();

        DisplayedText.text = "1:  " + record.record1 + "\n" 
            + "2:  " + record.record2 + "\n" 
            + "3:  " + record.record3 + "\n";
        
    }
}
