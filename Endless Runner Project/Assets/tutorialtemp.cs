using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialtemp : MonoBehaviour
{
    Rigidbody2D tutorial;

    // Start is called before the first frame update
    void Start()
    {
        tutorial = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tutorial.velocity = new Vector2(-3.5f, tutorial.velocity.y);
    }
}
