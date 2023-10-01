using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCamera : MonoBehaviour
{
    public GameObject playertemp;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playertemp.transform.position.x, transform.position.y, transform.position.z);
    }
}
