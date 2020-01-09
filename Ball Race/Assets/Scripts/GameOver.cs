using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Double time = Math.Round(DisplayTime.currentTime - DisplayTime.startTime, 2);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fileStream = new FileStream(Application.dataPath + "/records.dat",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);

            fileStream.Position = 0;
            Record record = bf.Deserialize(fileStream) as Record;
 
            if (time < record.record1){
                record.record3 = record.record2;
                record.record2 = record.record1;
                record.record1 = time;
            }  else if (time < record.record2){
                record.record3 = record.record2;
                record.record2 = time;
            } else if (time < record.record3){
                record.record3 = time;
            }

            fileStream.Close();
            File.WriteAllText(Application.dataPath + "/records.dat", String.Empty);
            fileStream = new FileStream(Application.dataPath + "/records.dat",
               FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fileStream, record);
            fileStream.Close();

            File.WriteAllText(Application.dataPath + "/playerTime.dat", String.Empty);
            fileStream = new FileStream(Application.dataPath + "/playerTime.dat",
               FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fileStream, new PlayerTime(time));
            fileStream.Close();

            SceneManager.LoadScene("ShowTime");
        }
    }
}
