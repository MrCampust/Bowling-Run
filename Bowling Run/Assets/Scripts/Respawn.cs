using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()  //Every FixedUpdate
    {
        if (transform.position.y < threshold)  //If Player falls off level
            transform.position = new Vector3(0, 0, 0);  //Teleports Player back to Spawn
    }
}