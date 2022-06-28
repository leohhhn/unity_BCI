using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_controler : MonoBehaviour
{
    int pointCounter = 0;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

     float moveForward = Input.GetAxis("Vertical");
     float moveHorizontal = Input.GetAxis("Horizontal");

     Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveForward);
     rb.AddForce(Vector3.Scale(movement, new Vector3(2,2,2)));

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject,0f);       
        pointCounter++;
        Debug.Log("Points collected: " + pointCounter);
    }


}
