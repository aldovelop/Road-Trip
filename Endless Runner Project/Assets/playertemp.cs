using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertemp : MonoBehaviour
{
    Rigidbody2D temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        temp.velocity = new Vector2(-1f, temp.velocity.y);
    }
}
