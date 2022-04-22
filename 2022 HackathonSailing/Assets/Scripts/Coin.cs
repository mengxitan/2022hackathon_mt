using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    public float turnSpeed = 90f; // coins rotating 90 degrees every second

    private void OnTriggerEnter (Collider other)
    {
        // Check whether the object colliding with is the ship
        if (other.gameObject.name != "Ship"){
            return; //stop the function from executing if the item isn't Ship
        }


        // Add to Player Score
        GameManager.inst.IncrementScore();

        // Destroy the Coin Object
        Destroy(gameObject);


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Rotate(0, 0, turnSpeed * Time.deltaTime); // rotate the coin along the z-axis 
        
    }
}
