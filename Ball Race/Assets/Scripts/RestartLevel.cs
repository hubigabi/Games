using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip audioClip;

    public static int levelNumber = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            audioSource.PlayOneShot(audioClip);

            if (levelNumber == 1)
            {
                GameObject.FindGameObjectsWithTag(strTag)[0].transform.position = new Vector3(0, 3.0F, -49.5F);
            }

            else if (levelNumber == 2) {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(0.0F, 2.5F, -3F);
            }

            else if (levelNumber == 3)
            {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(-38.98F, 10.0F, 160.9F);
            }

            else if (levelNumber == 4)
            {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(57.37F, 20.0F, 184.42F);
            }

            GameObject.FindGameObjectsWithTag(strTag)[0].GetComponent<Rigidbody>().velocity = new Vector3(0.0F, 0.0F, 0.0F);
        }
    }
}
