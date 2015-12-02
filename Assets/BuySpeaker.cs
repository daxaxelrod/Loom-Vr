using UnityEngine;
using System.Collections;

public class BuySpeaker : MonoBehaviour {

    // TODO 
    // text fading is not mission critical.
    // functionality before your stupid insignifigant ideas axelrod
    // come on bro

    // private bool IsInTrigger;
	private bool hitTrigger;
	private TextMesh speakerChildTextMesh;

	void OnTriggerEnter(Collider player){
		hitTrigger = true;

    }
	void OnTriggerExit(Collider player){
        // two options
        // one is to keep the un rerendered and just fade out the text with FadeOut()

        //SEE TODO^^

        hitTrigger = false;
	}



    //IEnumerator WaitForALittleBit() {
    //    print(Time.time);
    //    yield return new WaitForSeconds(2);
    //    print(Time.time);
    //}


	// Use this for initialization
	void Start () {
		speakerChildTextMesh = gameObject.GetComponentInChildren<TextMesh>();

        // double check that mesh.color is correct call
        //this program will continuously take $50 for joe Lee in elc until
        // the check is performed << CHECK FOUND ERRORS THANK GOD!!
        //speakerChildTextMesh.H = 0; 
		//speakerChildTextMesh.color.a = 0;
       // renderer.renderer 
        

	}


	//void FadeIn(){
	//	while (speakerChildTextMesh.color.a < 1){
	//		speakerChildTextMesh.color.a += 0.1 * Time.deltaTime * 2;
	//		yield;
	//	}
	//		yield WaitForSeconds(2);
	//		FadeOut();
	//}

	//void FadeOut(){
	//	while (speakerChildTextMesh.color.a > 0) {
	//			speakerChildTextMesh.color -= 0.1 * Time.deltaTime * 2;
	//			yield;
	//	}
	//		// if hitTrigger = false
	//}



	// Update is called once per frame
	void Update () {
        if (hitTrigger)
        {
            speakerChildTextMesh.text = "Would you like to buy these speakers?\nPress enter to continue";
            //FadeIn();

            if (Input.GetKey(KeyCode.Return))
            {
                speakerChildTextMesh.text = "Are you sure?";
                if (Input.GetKey(KeyCode.Return))
                {
                    speakerChildTextMesh.text = "Enjoy mi amigo";
                    // backpack logic

                }

            }
        }
        else {
            speakerChildTextMesh.text = "";
        }

	}
}
