using UnityEngine;
using System.Collections;
using System;

public class WinWaterCarnivalGame : MonoBehaviour {


    private bool hitTrigger;
    private int indexOfWinner;

    private void OnTriggerEnter(Collider winningBox) {
        //gets the name of the cube
        // they all look like PlayerCube9 with the index of the player at the end

  //      indexOfWinner = Int32.TryParse(indexOfWinner.name.ToCharArray()[9]);
        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
