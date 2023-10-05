using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        if (mousePos.y > 0)
        {
            mousePos.y = 0;
        }

        //transform.position = mousePos; neveikia
        var finalPosition = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(finalPosition);
    }
}
