using UnityEngine;
using System.Collections;
using System;

public class FruitGameMach2 : MonoBehaviour {

    private GameObject fruit;
    private int fruitCount;
    public float spawnWait;
    public float startWait;
    public float birdWait;

    public GUIText scoreText;


    private int totalScore;

    public PlayerBlackboard blackBoard;
    private float gameEuros;
    private bool hasTheGameEnded;
    private int fruitsToWin;



    // Use this for initialization
    void Start () {
        totalScore = 0;
        UpdateScore();
        blackBoard = GameObject.FindGameObjectWithTag(Tags.MainCamera).GetComponent<PlayerBlackboard>();
        fruitsToWin = 50;

	}

    private void UpdateScore()
    {
        throw new NotImplementedException();
    }

    IEnumerator SpawnWaves() {
        yield return new WaitForSeconds(startWait);
    }
	

	// Update is called once per frame
	void Update () {
        // add whatever money the player has made
        // what determines if the game has ended
        if (hasTheGameEnded) {
            blackBoard.euros += gameEuros;
        }
        else {
            // play the game if it is still valid
            playGame();

        }


	}


    void playGame() {
        if (totalScore >= fruitsToWin)
        {
            Debug.Log("Congrats, you've won our little game here");
            hasTheGameEnded = true;
        }
        // do all the game logic in here?


    }






}
