using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchGracza : MonoBehaviour
{
    public float speed = 30;

    void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw ("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
