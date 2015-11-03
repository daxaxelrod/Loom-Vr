using UnityEngine;
using System.Collections;

public class PressQForInception : MonoBehaviour {

    private bool enteredInceptionZone = false;
    private int inceptionTurner = 5;



    public void OnTriggerEnter(Collider camera)
    {
        enteredInceptionZone = true;
    }

    public void OnTriggerExit(Collider camera)
    {
        Debug.Log("BWAAAAA you left, BWAAAA");
        enteredInceptionZone = false;
        
    }




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q) || enteredInceptionZone) {
            gameObject.transform.Rotate(inceptionTurner*Vector3.back*Time.deltaTime ,Space.Self);
        }
	
	}
}
