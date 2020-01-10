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


    int diamenty = ControllPlayer.diamond;

    void Update()
    {
        diamenty = ControllPlayer.diamond;
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (move)
            {
                if (((toLevel!=3) && (toLevel!=5)) || ((toLevel==3 || toLevel==5)&& diamenty==3))
                {
                    GameObject.FindGameObjectsWithTag("Player")[0].transform.position = new Vector3(xPosition, yPosition, zPosition);
                    GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Rigidbody>().velocity = new Vector3(0.0F, 0.0F, 0.0F);
                    RestartLevel.levelNumber = toLevel;
                }
                else if(toLevel == 3)
                {                   
                    RestartLevel.levelNumber = 2;                                       
                }
                
            }

        }
            
    }

}

