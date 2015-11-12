using UnityEngine;
using System.Collections;

public class start_gamify_fruit : MonoBehaviour {

    private bool hitTrigger = false;
    private AudioSource audio;
    private 

    void OnTriggerEnter(Collider player)
    {
        Debug.Log("Hit trigger");
        if (GetComponent<AudioSource>() != null)
        {
            Debug.Log("in audio if");
            //press spacebar for game?!?!?!?!?!?
            //woot
            //..
            //..
            //woot
            audio = GetComponent<AudioSource>();
            audio.Play();
        }
        hitTrigger = true;
    }

	// Use this for initialization
	void Start () {
      
        //maybbbbeeeere
        //  BoxCollider boxThing;


	}
	
	// Update is called once per frame
	void Update () {
        if (hitTrigger) {
            if (Input.GetKey(KeyCode.Space)) {

                Debug.Log("in space and hittrigger if");
                Application.LoadLevel(1);

            }
        }
	
	}
}
