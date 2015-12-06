using UnityEngine;
using System.Collections;
// using 

public class BuyChairScript : MonoBehaviour {

    private bool hitTrigger = false;
    private bool isKeyPressed = false;
    private TextMesh chairBuyTextMesh;

    void OnTriggerEnter(Collider player) {
        hitTrigger = true;
    }
    
    void OnTriggerExit(Collider player) {
        hitTrigger = false;
    }

	// Use this for initialization
	void Start () {
           chairBuyTextMesh = gameObject.GetComponentInChildren<TextMesh>();

    }

    private void ChangeTextMesh(string textToChangeTo) {
        chairBuyTextMesh.text = textToChangeTo;
    }

	// Update is called once per frame
	void Update () {

        if (hitTrigger)
        {
            chairBuyTextMesh.text = "This chair costs 35 Euros\n Press enter to purchase";
            if (Input.GetKey(KeyCode.Return))

            {
                //warning message
                ChangeTextMesh("Are you sure? \n press enter to continue");
                // isKeyPressed = true;
                // set it so it doesn't trigger the event
                if (Input.GetKey(KeyCode.Return))
                {

                    // meathods for adding to backpack
                  //  addToBackPack(gameObject);

                    

                    ChangeTextMesh("It's all yours!");
                }

            }
        }
        else {
            chairBuyTextMesh.text = "";
        }

      
       



        //IEnumerator ExampleWait(){
        //    //
        //    yield  new WaitForSeconds(6);

        //}


    }
}
