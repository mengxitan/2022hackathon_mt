using System.Collections;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

    public float speed = 10;
    public Rigidbody rb;

    float horizontalInput;
    public float horitzontalMultiplier = 2;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime; 
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horitzontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove); 
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
    }
}
