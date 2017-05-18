using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {
        GameObject Player = GameObject.Find("Player");

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = Player.transform.position;
        }
    }
}