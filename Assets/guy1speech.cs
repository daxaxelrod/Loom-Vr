using UnityEngine;
using System.Collections;

public class guy1speech : MonoBehaviour {

    AudioSource[] buildingDescription;
    private float timeDelay;
    private float snowTimer;
    private int counter = 0;


    

    void OnTriggerEnter(Collider player)
    {
        // snowTimer = Time.time;

        // Debug.Log(snowTimer);
        buildingDescription = GetComponents<AudioSource>();
        buildingDescription[0].Play();
        timeDelay = 3f;
        for (int audioPos = 1; audioPos < buildingDescription.Length; audioPos++)
        {
            timeDelay += buildingDescription[audioPos].time;
            //wow that works well
            //basically can add as many audios to this as you want and it will play them one after another
            buildingDescription[1].PlayDelayed(timeDelay);
            
        }
    }
    void OnTriggerStay(Collider player)
    {
        // lets do it on the trigger of the sound rather than the time
        //snowTimer = Time.time;
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
        counter++;
        Debug.Log(counter);
        if (counter >= 500) {
            // GameObject.FindGameObjectWithTag("Snow").SetActive(true);
            // snowBall.SetActive(true);



            //if (snowTimer > ( startTime + 7)) {
            // Debug.Log("7 seconds have elapsed since the trigger has been hit");
        }
	}
}
