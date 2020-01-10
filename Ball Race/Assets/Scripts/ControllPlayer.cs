using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllPlayer : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    public static int diamond = 0;
    int diax = 0;
    public Text diamondV;

    void FixedUpdate ()
    {
        if (Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Diamond")
        {
            Destroy(collision.gameObject, 0.01f);
            diax = diax + 1;
            diamond = diax;          
            diamondV.text = diamond.ToString();
        }

        if (collision.gameObject.tag == "Level2")
        {
            diamond = 0;
            diax = 0;
            diamondV.text = diamond.ToString();
            Destroy(collision.gameObject, 0.01f);
        }



    }


}
