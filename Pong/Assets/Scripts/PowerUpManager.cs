using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpManager : MonoBehaviour
{
    public GameObject powerUp;
    GameObject leftPlayer;
    GameObject rightPlayer;
    float timeRepetition = 8.0F;
    float timeToEnd = 0.0F;
    Text textUIComp;

    // Start is called before the first frame update
    void Start()
    {
        leftPlayer = GameObject.Find("LewyGracz");
        rightPlayer = GameObject.Find("PrawyGracz");
        textUIComp = GameObject.Find("TimeUI").GetComponent<Text>();

        InvokeRepeating("UpdatePowerUp", 2.0f, timeRepetition);
        InvokeRepeating("Updatetime", 2.0f, 0.1F);
    }

    void UpdatePowerUp(){
        leftPlayer.GetComponent<Rigidbody2D>().transform.localScale = new Vector2(1.0F, 1.0F);
        rightPlayer.GetComponent<Rigidbody2D>().transform.localScale = new Vector2(1.0F, 1.0F);

        GameObject gameObject = GameObject.FindGameObjectWithTag("PowerUp");
        if (gameObject != null)
        {
            Destroy(gameObject);
        }

        float x = Random.Range(-10, 10);
        float y = Random.Range(-15, 15);
        Instantiate(powerUp, new Vector2(x, y), Quaternion.identity);

        timeToEnd = timeRepetition;
    }

    void Updatetime() {
        timeToEnd -= 0.1F;
        textUIComp.text = timeToEnd.ToString("#.0"); ;
    }
}
