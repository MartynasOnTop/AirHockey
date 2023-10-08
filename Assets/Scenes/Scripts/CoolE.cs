using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolE : MonoBehaviour
{

    public Transform EnemyText;
    bool shouldRespawn;

    public float respawnCooldown;
    float respawnTimer;
    Vector3 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldRespawn)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                transform.position = respawnPosition;
                respawnTimer = respawnCooldown;
                shouldRespawn = false;
            }
        }
    }
}
