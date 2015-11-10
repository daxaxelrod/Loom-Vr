using UnityEngine;
using System.Collections;

public class guy1speech : MonoBehaviour {

    AudioSource[] buildingDescription;


    void OnTriggerEnter(Collider player)
    {
        buildingDescription = GetComponents<AudioSource>();
        buildingDescription[0].Play();
        float timeDelay = 5;
        for (int audioPos = 1; audioPos < buildingDescription.Length; audioPos++)
        {
            timeDelay += buildingDescription[audioPos].time;
            //wow that works well
            //basically can add as many audios to this as you want and it will play them one after another
            buildingDescription[1].PlayDelayed(timeDelay);
            Debug.Log("your gonna be up for more than an hour");
        }
    }



    void OnCollisionEnter(Collision camera)
    {
     //   buildingDescription = GetComponent<AudioSource>();
      //  buildingDescription.Play();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
