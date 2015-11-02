using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour
{


    /*
        if the camera collides with something


    lerp camera in Z direction towards playerObject to minimum distance from playerObject(that way camera never goes through playerObject)


    if camera is at minimum distance, lerp opacity of playerObject material to 30% (so player doesnt block view of environment)


    if camera exits collision


    lerp camera in Z direction away from playerObject to maximum distance from player
    lerp playerObject material opacity to 100%
    */

    public void onTriggerEnter(Collider camera) {
        Debug.Log("Entered the spherical zone");
        return;
    }


	// Use this for initialization
	void Start () {

      //  Collider sphereCollider = new Collider();
        

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
