using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.name.Contains("Goal"))
            {
                transform.position = Vector3.zero;
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }

            if (other.gameObject.name.Contains("Enemy Goal"))
            {

            }
            
            if (other.gameObject.name.Contains("Player Goal"))
            {

            }
        }
    }
}
