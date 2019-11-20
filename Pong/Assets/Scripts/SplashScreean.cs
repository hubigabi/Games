using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreean : MonoBehaviour
{
    public string sceneToLoad;

    public int secTillSceneLoad;
    void Start()
    {
        Invoke("OpenNextScene", secTillSceneLoad);
    }

    void OpenNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
