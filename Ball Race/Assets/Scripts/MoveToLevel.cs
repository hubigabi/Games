using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel : MonoBehaviour
{ 
   [SerializeField]
    float xPosition;

    [SerializeField]
    float yPosition;

    [SerializeField]
    float zPosition;

    [SerializeField]
    int toLevel;

    [SerializeField]
    bool move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (move)
            {
                GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(xPosition, yPosition, zPosition);
                GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Rigidbody>().velocity = new Vector3(0.0F, 0.0F, 0.0F);
            }
            RestartLevel.levelNumber = toLevel;
        }

    }
}
