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
                GameObject.FindGameObjectsWithTag(strTag)[0].transform.position = new Vector3(0, 2.0F, -46.5F);
            }
            else if (levelNumber == 2) {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(0.0F, 2.0F, -1.5F);
            }
            else if (levelNumber == 3)
            {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(-4.2F, 3.2F, 41.0F);
            }
            GameObject.FindGameObjectsWithTag(strTag)[0].GetComponent<Rigidbody>().velocity = new Vector3(0.0F, 0.0F, 0.0F);
        }
    }
}
