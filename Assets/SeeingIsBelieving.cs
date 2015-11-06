using UnityEngine;
using System.Collections;

public class SeeingIsBelieving : MonoBehaviour {


    RaycastHit hit;
    private float raycastTimeLength = 1000;


    private Ray cameraRay;





    // Use this for initialization
    void Start () {
        //sets a new ray from the camera to where the camera is looking

        //  GameObject gameCamera = GameObject.Find("CenterEyeAnchor");

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



        /* //---------------------------------todo-------------------------------------------------------------------
        
        1) when something gets hit, add an empty child node
        2) Attach new textmesh and add the textmesh.text equal to the title of the parent
        3) transform.Translate the childnode closer to the camera
        4) Don't allow the ray to go through more than one element
        5) have the child node self destruct after 10 seconds
        
        //if left mouse key is pressed, shoot a ray, if the ray hits anything, take the name of the hit 
        //item and return it as a mesh text

        
        */ //---------------------------------todo-------------------------------------------------------------------



        //keep getting error object reference not set to an instanec of an object
        //what the actual fuck

        //TODO come back to line 41 and fix the ray physics


        // cameraRay = new Ray((gameObject.transform.position), gameObject.transform.eulerAngles + centerEyePose.transform.position);

        //returns an error saying that the current expression denotes a method group
        //Debug.Log(GetType());
        GameObject building = GameObject.Find("test_collider");
        //center eye anchor is a gameobject, not a camera
       GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        //why they thought that was a good idea, i have no clue. Useful in other contexts as well though


        if (Input.GetKey(KeyCode.A)) {
            //Debug.DrawRay(new Vector3(-11f, 9.6f, -49.58f), gameObject.transform.forward, Color.red, 10);
            // Debug.DrawRay(gameObject.transform.position, camera.transform.foward);
            Ray rayFromCamera = new Ray(mainCamera.transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast( rayFromCamera, out hit) ) {
                TextMesh newMeshToDestroyIn5s = mainCamera.AddComponent<TextMesh>();


                //null object reference
                //newMeshToDestroyIn5s.transform.parent = mainCamera.transform;
                Debug.Log(newMeshToDestroyIn5s);
                //Debug.Log(mainCamera.transform);
                    


                // a collision occued. Check if it's our plane object and create our cuve at the 
                // collision point facing toward the collision normal



                Collider buildingCollider = building.GetComponent<Collider>();

                 
                // thing was hit != !null
                if (hit.collider == buildingCollider) {
           //          Debug.Log("HOLY FUCK IT ACCTUALLY WORKS!!");  
                    //hit happened

                }
             }
            Debug.DrawRay(rayFromCamera.origin, rayFromCamera.direction * 500000, Color.red, raycastTimeLength);
           // Debug.Log("Ray Drawn");
           //Debug.Log(rayToUse.direction);


        }
            
        
	
	}
}
