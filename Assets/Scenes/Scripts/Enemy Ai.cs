using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform defensePoint;
    public Transform ball;
    
    private float speed = 5;
    public float attackSpeed = 20;
    public float defenseSpeed = 20;

    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Puck"))
        {
            GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

        bool ballInRange = ball.position.y >= 0;

        if (ballInRange)
        {
            targetPosition = ball.position;
            speed = attackSpeed;
        }
        else
        {
            targetPosition = defensePoint.position;
            speed = defenseSpeed;
        }
        var finalPosition = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(finalPosition);

    }
}
