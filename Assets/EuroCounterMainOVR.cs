using UnityEngine;
using System.Collections;

public class EuroCounterMainOVR : MonoBehaviour {

    public decimal euros = 0.00m;
    private TextMesh euroCounterText;
    public ArrayList possesions;


	// Use this for initialization
	void Start () {
        euroCounterText = gameObject.GetComponentInChildren<TextMesh>();

        // create backpack
        //nope not add
        //possesions.Add();

        GameObject map = Instantiate(Resources.Load("David_Objects_Prefabs", typeof(GameObject))) as GameObject;

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

        // debug
          if (Input.GetKey(KeyCode.B)) {
            if (euros> 20) {
                euros = euros * euros/ (decimal) Time.deltaTime;
                
            } else {
                euros += 1;
            }
        }
	
	}
}
