using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    GameObject leftPlayer;
    GameObject rightPlayer;
    static int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        leftPlayer = GameObject.Find("LewyGracz");
        rightPlayer = GameObject.Find("PrawyGracz");

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (counter == 0)
        {
            spriteRenderer.color = Color.green;
        }
        else if (counter == 1)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.yellow;
        }

        counter++;
        if (counter >= 3)
        {
            counter = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        GameObject ball = GameObject.Find("Ball");
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        if (counter == 1)
        {
            if (rb.velocity.x > 0)
            {
                leftPlayer.GetComponent<Rigidbody2D>().transform.localScale *= new Vector2(1.0F, 3.5F);
            }
            else
            {
                rightPlayer.GetComponent<Rigidbody2D>().transform.localScale *= new Vector2(1.0F, 3.5F);
            }
        }
        else if (counter == 2)
        {
            if (rb.velocity.x > 0)
            {
                leftPlayer.GetComponent<Rigidbody2D>().transform.localScale *= new Vector2(1.0F, 0.5F);
            }
            else
            {
                rightPlayer.GetComponent<Rigidbody2D>().transform.localScale *= new Vector2(1.0F, 0.5F);
            }
        }
        else {
            rb.velocity *= new Vector2(2.0F, 2.0F);
        }
    }
}
