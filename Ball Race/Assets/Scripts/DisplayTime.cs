using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTime : MonoBehaviour
{

    string text = "";
    double startTime = 0.0;
    double currentTime = 0.0;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = Time.realtimeSinceStartup;
        text = Math.Round(currentTime - startTime, 1).ToString();
    }

    void OnGUI()
    {
        GUI.contentColor = Color.red;
        GUI.skin.label.fontSize = 30;
        GUI.Label(new Rect(0, 0, 200, 200), " Time: " + text);
    }
}
