using UnityEngine;
using System.Collections;

public class BackToMainScene : MonoBehaviour {


    private bool hitTrigger = false;
    private TextMesh referencedTextMesh;

    void OnTriggerEnter(Collider player)
    {
        hitTrigger = true;
    }

    void OnTriggerExit(Collider player)
    {
        hitTrigger = false;
    }


    // Use this for initialization
    void Start()
    {
        // *********************************************************
        //as time goes on, start is becoming less and less nessisary
        // *********************************************************
        //  make it nativly rather than programmatically
        //   textToLeave = new GameObject("textToLeave");
        //   textToLeave.AddComponent<TextMesh>();
             referencedTextMesh = gameObject.GetComponentInChildren<TextMesh>();
    }            

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hitTrigger);
        if (hitTrigger)
        {
            // append a child with the text mesh
            // textToLeave.transform.parent = gameObject.transform;
            //   TextMesh refrencedTextMesh = textToLeave.GetComponent<TextMesh>();
            // append the correct text,
            referencedTextMesh.text = "Press enter to return to mardid";
            if (Input.GetKey(KeyCode.Return))
            {
                referencedTextMesh.text = "Hold on to your hats!!";
                Application.LoadLevel(0);
            }
            // set up the logic
            // load the new scene

            // hitTrigger = false;

        }
        else {
                                    // maybe to flash in future??
            referencedTextMesh.text = "Leave";
        }


    }
}

