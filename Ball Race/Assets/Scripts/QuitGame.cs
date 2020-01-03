using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;
	
	void Update ()
    {
        if (Input.GetKey(keyRestart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            RestartLevel.levelNumber = 1;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
            RestartLevel.levelNumber = 1;
        }

    }
}
