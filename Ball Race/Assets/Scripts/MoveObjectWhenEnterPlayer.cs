using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWhenEnterPlayer : MonoBehaviour
{
    [SerializeField]
    float XMovement;

    [SerializeField]
    float YMovement;

    [SerializeField]
    float ZMovement;

    bool move = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            transform.position += new Vector3(XMovement * Time.deltaTime, YMovement * Time.deltaTime, ZMovement * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            move = true;
        }

        if (collision.collider.tag != "Player")
        {
            XMovement *= -1;
            YMovement *= -1;
            ZMovement *= -1;
        }

    }


}
