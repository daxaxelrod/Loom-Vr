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
    private int score;


	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
        
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
	
	}
}
