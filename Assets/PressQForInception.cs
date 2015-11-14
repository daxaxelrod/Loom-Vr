using UnityEngine;
using System.Collections;

public class PressQForInception : MonoBehaviour {

   
    private int inceptionTurner = 10;
    bool dudeStartTheBWWWAAAAAWWWSSS = false;
    int counter = 0;


    public void OnTriggerEnter(Collider camera)
    {
        dudeStartTheBWWWAAAAAWWWSSS = true;
    }

    public void OnTriggerExit(Collider camera)
    {
        Debug.Log("BWAAAAA you left, BWAAAA");
        //dudeStartTheBWWWAAAAAWWWSSS = false;
        
    }




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (dudeStartTheBWWWAAAAAWWWSSS) {
            counter++;
        }


        if (dudeStartTheBWWWAAAAAWWWSSS && counter < 375) {

            gameObject.transform.Rotate(inceptionTurner * Vector3.back * Time.deltaTime, Space.Self);
            counter++;
            
        }
        if (counter > 375) {
            // loads the new scene after the bwaaahhh finish
        
            Application.LoadLevel(2);
        }
   
	}
}
