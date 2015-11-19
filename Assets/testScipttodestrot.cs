using UnityEngine;
using System.Collections;

public class testScipttodestrot : MonoBehaviour {

    // VARIABLE 
    private GameObject buildingToMove;
    private bool hitTrigger = false;

    void OnTriggerEnter(Collider player) {

        hitTrigger = true;
        
    }
    void OnTriggerStay() {

    }
    void OnTriggerExit(Collider player) {
        hitTrigger = false;
    }
    void OnCollisionEnter(Collision hit) {
        
    }





	// Use this for initialization
	void Start () {
        buildingToMove = GameObject.FindGameObjectWithTag("learningAndBuildingMoveYolo");
        
	}
	


	// Update is called once per frame
	void Update () {
        //        gameObject

        if (hitTrigger) {
            buildingToMove.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);
        }
        //    if (Input.GetKey(KeyCode.Space)) { 
        //buildingToMove.transform.Translate(new Vector3(0,5,0)* Time.deltaTime, Space.Self);
        //}

    }
}
