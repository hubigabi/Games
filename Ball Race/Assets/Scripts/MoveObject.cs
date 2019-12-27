using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    float XMovement;

    [SerializeField]
    float YMovement;

    [SerializeField]
    float ZMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(XMovement * Time.deltaTime, YMovement * Time.deltaTime, ZMovement * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Player")
        {
            XMovement *= -1;
            YMovement *= -1;
            ZMovement *= -1;
        }

    }

}
