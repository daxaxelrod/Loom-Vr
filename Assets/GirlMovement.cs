using UnityEngine;
using System.Collections;

public class GirlMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {

        MeshRenderer m = gameObject.GetComponent<MeshRenderer>();
        
    //    m._e


        foreach (Transform extremity in gameObject.transform)

            Debug.Log(extremity);

    }


	
	// Update is called once per frame
	void Update () {

        
	
	}

}