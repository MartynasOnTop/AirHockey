using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public TMP_Text PlayerScore;
    public TMP_Text EnemyScore;

    public TMP_Text PlayerGoal;
    public TMP_Text EnemyGoal;

    int PlayerPoints = 0;
    int EnemyPoints = 0;

    public Transform deathPoint;
    public Transform EnemyText;
    public Transform PlayerText;
    bool shouldRespawn;
    bool shouldHide;

    public float respawnCooldown;
    float respawnTimer;
    Vector3 respawnPosition;

    void Start()
    {
        respawnTimer = respawnCooldown;
    }

    void Update()
    {
        PlayerScore.text = PlayerPoints.ToString();
        EnemyScore.text = EnemyPoints.ToString();
        if (shouldRespawn)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                transform.position = respawnPosition;
                EnemyGoal.transform.position = EnemyText.position;
                PlayerGoal.transform.position = PlayerText.position;
                respawnTimer = respawnCooldown;
                shouldRespawn = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name.Contains("EnemyScores"))
        {
            EnemyPoints += 1;
            respawnPosition = Vector3.down;

            EnemyGoal.transform.position = Vector3.up;

            //transform.position = Vector3.down;


        }
        if (collision.gameObject.name.Contains("PlayerScores"))
        {
            PlayerPoints += 1;
            respawnPosition = Vector3.up;

            PlayerGoal.transform.position = Vector3.down;

            //transform.position = Vector3.up;

        }
        if (collision.gameObject.name.Contains("Wall"))
        {
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.name.Contains("Scores"))
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = deathPoint.position;


            shouldRespawn = true;

            if (PlayerPoints >= 7 || EnemyPoints >= 7)
            {
                SceneManager.LoadScene("Menu");
            }
        }

    }
}
