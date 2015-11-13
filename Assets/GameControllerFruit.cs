using UnityEngine;
using System.Collections;


public class GameControllerFruit : MonoBehaviour {

    private int superCounter = 0;

    private GameObject[] appleInstance;
    private int[] appleCounter;

    private GameObject[] bananaInstance;
    private int[] bananaCounter;
    //  private GameObject fruitIntance2;

    private GameObject boy;
    private AudioSource boyAudio;
    



	// Use this for initialization
   	void Start () {
            if(appleInstance == null) {
            appleInstance = GameObject.FindGameObjectsWithTag("fruitApple");
            appleCounter = new int[appleInstance.Length];

            }

            if (bananaInstance == null)
            {
            bananaInstance = GameObject.FindGameObjectsWithTag("fruitBanana");
            bananaCounter = new int[bananaInstance.Length];
            }

        boy = GameObject.FindGameObjectWithTag("boy");
        boyAudio = boy.GetComponent<AudioSource>();

    }

    //60 fps
    // Update is called once per frame
    void Update () {

        if (superCounter > 25 && superCounter < 60) {
            boy.transform.Rotate(Vector3.down);
        } 
        if (!boyAudio.isPlaying && superCounter == 0) {
            boyAudio.Play();
            }
            
        
        //note to self this is super taxing and all the fruits should be in their own respective parents

        if (superCounter < 300){
            for (int i = 0; i < appleInstance.Length; i++)
            {
                // SleepTimeout timeout = new SleepTimeout();
                appleInstance[i].transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

                // switch (i) not gonna work
                // { }
                //case 0:
            }
            for (int i = 0; i < bananaInstance.Length; i++) {

                bananaInstance[i].transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

            }

            boy.transform.Translate(new Vector3(-.5f, 0, 0) * Time.deltaTime, Space.Self);

        }
        if (superCounter > 300 && superCounter < 600) {
            //tranform the fruits forward and start the boy help text.
        }
        
        superCounter++;



    }
}
