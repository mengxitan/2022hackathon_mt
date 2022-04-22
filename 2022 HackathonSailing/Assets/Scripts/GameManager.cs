using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public int score;
    public static GameManager inst;

    public Text scoreText;

    public ShipMovement shipMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE:" + score;
        //Increase the player's speed based on points
        shipMovement.speed += shipMovement.speedIncreasePerPoint;
    }

    private void Awake()
    {

        inst = this;


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
