using UnityEngine;
using System.Collections;

public class EuroCounterMainOVR : MonoBehaviour {

    public double euros = 0;
    private TextMesh euroCounterText;

	// Use this for initialization
	void Start () {
        euroCounterText = gameObject.GetComponentInChildren<TextMesh>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (euros != 0)
        {
            // say they have the updated euro count
        }
        else {
            // get the text in the child text mesh
        }
	
	}
}
