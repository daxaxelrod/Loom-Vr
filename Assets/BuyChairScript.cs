using UnityEngine;
using System.Collections;

public class BuyChairScript : MonoBehaviour {

    private bool hitTrigger = false;
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
	
	// Update is called once per frame
	void Update () {

        

        if (hitTrigger) {
            chairBuyTextMesh.text = "This chair costs 35 Euros\n Press enter to purchase";
            if (Input.GetKey(KeyCode.Return)) {
                //warning message
                chairBuyTextMesh.text = "Are you sure? \n press enter to continue";
                if (Input.GetKey(KeyCode.Return)) {
                    chairBuyTextMesh.text = "It's all yours!";
                }
            }

        }

	
	}
}
