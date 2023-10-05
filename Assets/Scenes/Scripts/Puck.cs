using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ball : MonoBehaviour
{
    public TMP_Text PlayerScore;
    public TMP_Text EnemyScore;
    int PlayerPoints = 0;
    int EnemyPoints = 0;

    void Start()
    {

    }

    void Update()
    {
        PlayerScore.text = PlayerPoints.ToString();
        EnemyScore.text = EnemyPoints.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name.Contains("Enemy Goal"))
        {
            EnemyPoints += 1;

            transform.position = Vector3.down;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        }
        if (collision.gameObject.name.Contains("Player Goal"))
        {
            PlayerPoints += 1;

            transform.position = Vector3.up;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        

    }
}
