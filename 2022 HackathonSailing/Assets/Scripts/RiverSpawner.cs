using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverSpawner : MonoBehaviour
{
    

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile () 
    {

        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity); //which object, where to spawn, rotation (in this case no rotation)
        nextSpawnPoint = temp.transform.GetChild(1).transform.position; //index starts from zero; this gets the 2nd item which is the spawner
    }


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++){

            SpawnTile();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
