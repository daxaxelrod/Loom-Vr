using UnityEngine;
using System.Collections;

public class BuyTable : MonoBehaviour {

    private bool hitTrigger = false;
    private TextMesh tableTextMesh;

    void OnTriggerEnter(Collider player) {
        hitTrigger = true;
    }

    void OnTriggerExit(Collider player) {
        hitTrigger = false;
    }

    // Use this for initialization
    void Start () {
        tableTextMesh = gameObject.GetComponentInChildren<TextMesh>();
	}

	// Update is called once per frame
	void Update () {
        if (hitTrigger)
        {
            tableTextMesh.text = "If you'd like to buy this table\n press enter";
            if (Input.GetKey(KeyCode.Return))
            {
                //message
                tableTextMesh.text = "Are you sure?";
                if (Input.GetKey(KeyCode.Return))
                {
                    tableTextMesh.text = "Enjoy!!";
                    //   hitTrigger = false;
                    // add table to the backpack
                    //  gameObject.transform.FindChild("table")
                }
            }
        }
        else {
            tableTextMesh.text = "";
        }

	}
}
