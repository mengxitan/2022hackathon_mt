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
        SpawnCoins();
    }

    private void OnTriggerExit (Collider other)
    {
        riverSpawner.SpawnTile();
        Destroy(gameObject, 2); //destroies the game object two seconds player leaves the trigger
    }

    public GameObject coinPrefab;

    public void SpawnCoins ()
    {

        int coinsToSpawn = 3;
        for (int i = 0; i < coinsToSpawn; i++){
                GameObject temp = Instantiate(coinPrefab, transform);
                temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }


    }

    Vector3 GetRandomPointInCollider (Collider collider)
    {

        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

        if (point != collider.ClosestPoint(point)){
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1; //ensure that the coins will spawn at the same height
        return point; //this function returns a vector
    }

}
