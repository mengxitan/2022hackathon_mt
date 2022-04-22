using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverTile : MonoBehaviour
{
    
    RiverSpawner riverSpawner;

    // Start is called before the first frame update
    void Start()
    {
        riverSpawner = GameObject.FindObjectOfType<RiverSpawner>();
    }

    private void OnTriggerExit (Collider other)
    {
        riverSpawner.SpawnTile();
        Destroy(gameObject, 2); //destroies the game object two seconds player leaves the trigger
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
