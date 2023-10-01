using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public AudioClip collect;
    AudioSource coinSFX;
    public static int best = 0;

    void Start()
    {
        coinSFX = GameObject.Find("SFX_Source").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ScoreScript.scoreValue += 1;
            coinSFX.PlayOneShot(collect);
            Destroy(gameObject);

            if (ScoreScript.scoreValue > best)
            {
                best = ScoreScript.scoreValue;
            }
        }
    }
}
