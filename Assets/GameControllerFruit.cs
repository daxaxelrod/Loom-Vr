using UnityEngine;
using System.Collections;

public class GameControllerFruit : MonoBehaviour {

    private GameObject[] fruitIntance;
  //  private GameObject fruitIntance2;

	// Use this for initialization
   	void Start () {
            if(fruitIntance == null) {
            fruitIntance = GameObject.FindGameObjectsWithTag("fruitApple");
            }

        for (int i = 0; i < fruitIntance.Length; i++)
        {

            fruitIntance[i].transform.Translate(new Vector3(0, 1, 0 * Time.deltaTime), Space.Self);


        }


    }

    // Update is called once per frame
    void Update () {




    }
}
