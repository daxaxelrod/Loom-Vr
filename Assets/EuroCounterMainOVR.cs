using UnityEngine;
using System.Collections;

public class EuroCounterMainOVR : MonoBehaviour {

    public decimal euros = 0.00m;
    private TextMesh euroCounterText;

	// Use this for initialization
	void Start () {
        euroCounterText = gameObject.GetComponentInChildren<TextMesh>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (euros == 0)
        {
            euroCounterText.text = "You have no money";
            
            
        }
        else {
            euroCounterText.text= "You have " + euros.ToString() + " Euros";
            //update the text with current dollar ammount 
            // get the text in the child text mesh
        }

        if (Input.GetKey(KeyCode.B)) {
            euros += 1;
            
        }
	
	}
}
