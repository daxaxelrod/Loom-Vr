using UnityEngine;
using System.Collections;

public class OpenAWindow : MonoBehaviour {
    public bool hitWindowTrigger = false;
    public int counter = 0;

    void OnTriggerEnter(Collider player) {

       //  = gameObject.GetComponentInChildren<TextMesh>();
        
        GameObject windowTextObject = new GameObject();
        windowTextObject.transform.parent = gameObject.transform;
        TextMesh windowText = windowTextObject.AddComponent<TextMesh>();
        windowText.text = "Abrir la Puerta con 'e' ";
        windowText.color = Color.red;
        hitWindowTrigger = true;


    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (hitWindowTrigger) {
            if (Input.GetKey(KeyCode.E) && counter < 80) {
                counter++;
                gameObject.transform.Translate(new Vector3(0,-0.05f,0));
            }

        }
	
	}
}
