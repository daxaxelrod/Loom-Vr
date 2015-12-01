using UnityEngine;
using System.Collections;

public class BuySpeaker : MonoBehaviour {

	private bool hitTrigger;
	private TextMesh speakerChildTextMesh;

	void OnTriggerEnter(Collider player){
		hitTrigger = true;

	}
	void OnTriggerExit(Collider player){
		// two options
		// one is to keep the un rerendered and just fade out the text with FadeOut()
	}


	// Use this for initialization
	void Start () {
		speakerChildTextMesh = gameObject.GetComponentInChildren<TextMesh>();
		// double check that mesh.color is correct call
		//this program will continuously take $50 for joe Lee in elc until
		// the check is performed
		speakerChildTextMesh.color.a = 0;

	}


	void FadeIn(){
		while (speakerChildTextMesh.color.a < 1){
			speakerChildTextMesh.color.a += 0.1 * Time.deltaTime * 2;
			yield;
		}
			yield WaitForSeconds(2);
			FadeOut();
	}

	void FadeOut(){
		while (speakerChildTextMesh.color.a > 0) {
				speakerChildTextMesh.color -= 0.1 * Time.deltaTime * 2;
				yield;
		}
			// if hitTrigger = false
	}



	// Update is called once per frame
	void Update () {
			if(hitTrigger){
				speakerChildTextMesh.text = "Would you like to buy these speakers?";
				FadeIn();

				if(Input.GetKey(KeyCode.enter)){

					if (Input.GetKey(KeyCode.enter)){


					}

				}
			}

	}
}
