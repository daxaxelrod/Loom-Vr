using UnityEngine;
using System.Collections;

public class SeeingIsBelieving : MonoBehaviour {


    RaycastHit hit;
    private float raycastLength = 1000;


    private Ray cameraRay;



    // Use this for initialization
    void Start () {
        //sets a new ray from the camera to where the camera is looking

          GameObject gameCamera = GameObject.Find("CenterEyeAnchor");

        //lies below

        // AHhhhyou can only use unity functions at the main thread level
        // start and update are main level functions. 
        //does that mean stuff at the top is secondary???
        // whatever bro
        //what
        //ever
        //

        // 
        //bro




}
	
	// Update is called once per frame
	void Update () {

        //if left mouse key is pressed, shoot a ray, if the ray hits anything, take the name of the hit 
        //item and return it as a mesh text



        //keep getting error object reference not set to an instanec of an object
        //what the actual fuck
       
        //TODO come back to line 41 and fix the ray physics

        
        // cameraRay = new Ray((gameObject.transform.position), gameObject.transform.eulerAngles + centerEyePose.transform.position);


        if (Input.GetMouseButton(0)) {
            Debug.DrawRay(transform.position, gameObject.transform.eulerAngles + gameObject.transform.position, Color.red, 10);
            Debug.Log("Ray Drawn");

        }
            
        
	
	}
}
