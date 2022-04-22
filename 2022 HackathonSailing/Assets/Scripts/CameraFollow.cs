using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform ship;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ship.position; //keep camera to be at the same distance from the ship
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = ship.position + offset;
        targetPos.x = 0; //x-value goes left and right
        transform.position = targetPos;
    }
}
