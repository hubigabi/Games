using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 30;

    private Rigidbody2D rigidBody;

    private AudioSource audioSource;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D> ();
        rigidBody.velocity = Vector2.right * speed;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //LeftPaddle
        if((collision.gameObject.name == "LewyGracz") || (collision.gameObject.name == "PrawyGracz"))
        {
            HandlePaddleHit(collision);
        }
        //WallBottom
        if((collision.gameObject.name == "ScianaDol") || (collision.gameObject.name == "ScianaGora"))
        {
            SoundManager.Instance.PlayOneShot (SoundManager.Instance.wallBloop);

        }
        //LeftGoal
        if ((collision.gameObject.name == "LewaBramka") || (collision.gameObject.name == "PrawaBramka"))
        {
            SoundManager.Instance.PlayOneShot (SoundManager.Instance.goalBloop);

            if(collision.gameObject.name=="LewaBramka")
            {
                IncreaseTextUIScore("RightScoreUI");
            }

            if (collision.gameObject.name == "PrawaBramka")
            {
                IncreaseTextUIScore("LeftScoreUI");
            }

            transform.position = new Vector2(0, 0);

        }
    }

    float BallHitPaddleWhere(Vector2 ball, Vector2 paddle, float paddleHeight)
    {
        return (ball.y - paddle.y) / paddleHeight;
    }

    void HandlePaddleHit(Collision2D collision)
    {
        float y = BallHitPaddleWhere (transform.position,
            collision.transform.position,
            collision.collider.bounds.size.y);

        Vector2 dir = new Vector2();

        if(collision.gameObject.name == "LewyGracz")
        {
            dir = new Vector2(1, y).normalized;
            Vector2 dir2 = dir = new Vector2(1, y);
            Debug.Log("Dir : " + dir + "Dir2 : " + dir2);
        }
        if(collision.gameObject.name == "PrawyGracz")
        {
            dir = new Vector2(-1, y).normalized;
        }

        rigidBody.velocity = dir * speed;

        SoundManager.Instance.PlayOneShot(SoundManager.Instance.hitPaddleBloop);
    }

    void IncreaseTextUIScore(string textUIName)
    {
        var textUIComp = GameObject.Find(textUIName).GetComponent<Text>();

        int score = int.Parse(textUIComp.text);

        score++;

        textUIComp.text = score.ToString();
    }
}
