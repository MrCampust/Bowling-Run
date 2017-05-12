using System.Collections;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    public float speed; //Initialzing variable for the script

    private Rigidbody rigidB; //Initialzing variable for the script

    void Start()   //At game start, do this
    {
        rigidB = GetComponent<Rigidbody>();
    }

    void FixedUpdate() //Every frame called for motion etc, it do this
    {
        float moveHorizontal = Input.GetAxis("Horizontal");     //Movement for Player
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidB.AddForce(movement * speed);
    }
}