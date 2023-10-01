using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuParallax : MonoBehaviour
{
    GameObject playertemp;
    Renderer rend;

    float playerStartPos;
    public float speed = 0.5f;

    void Start()
    {
        playertemp = GameObject.Find("playertemp");
        rend = GetComponent<Renderer>();
        playerStartPos = playertemp.transform.position.x;
    }

    void Update()
    {
        float offset = (playertemp.transform.position.x - playerStartPos) * speed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}