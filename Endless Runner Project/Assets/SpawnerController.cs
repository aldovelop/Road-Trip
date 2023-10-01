using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    Rigidbody2D spawnerObject;
    public GameObject player;
    void Start()
    {
        spawnerObject = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //spawnerObject.velocity = new Vector2(-4.0f, spawnerObject.velocity.y);
        if (spawnerObject.velocity.x == 0f)
        {
            spawnerObject.velocity = new Vector2(-10.0f, spawnerObject.velocity.y);
        } else if (spawnerObject.velocity.x < 0f)
        {
            transform.position = new Vector3(player.transform.position.x -20f, transform.position.y, transform.position.z);
        }
    }
}
