using UnityEngine;
using System.Collections;

public class StopCameraMovement : MonoBehaviour {


    public void onTriggerEnter(Collider camera) {

        camera.transform.position.Set(0, 0, 0);


    }

    public void onTriggerExit(Collider camera) {

        Debug.Log("#YOLOSWAG youve left the collider of the brick house. Hazzah");

        return;

           
    }



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
