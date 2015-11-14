using UnityEngine;
using System.Collections;


public class GameControllerFruit : MonoBehaviour {

    private int superCounter = 0;

    private GameObject appleInstance;
    private int[] appleCounter;

    private GameObject bananaInstance;
    private int[] bananaCounter;
    //  private GameObject fruitIntance2;

    private GameObject boy;
    private AudioSource boyAudio;
    private TextMesh guidingText;
    private Transform textObject;
    private AudioSource gameMusic;

    

    // Use this for initialization
    void Start () {
            if(appleInstance == null) {
            appleInstance = GameObject.FindGameObjectWithTag("AppleGrouping1");
            }

            if (bananaInstance == null)
            {
            bananaInstance = GameObject.FindGameObjectWithTag("BananaGrouping1");
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

            appleInstance.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);
            bananaInstance.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

          //  bananaInstance.trans

            //for (int i = 0; i < appleInstance.Length; i++)
            //{
            //    // SleepTimeout timeout = new SleepTimeout();
            //    appleInstance[i].transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

            //    // switch (i) not gonna work
            //    // { }
            //    //case 0:
            //}
            //for (int i = 0; i < bananaInstance.Length; i++) {

            //    bananaInstance[i].transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

            //}

            boy.transform.Translate(new Vector3(-.5f, 0, 0) * Time.deltaTime, Space.Self);

        }
        if (superCounter > 300 && superCounter < 600) {
            //tranform the fruits forward and start the boy help text.
            guidingText = boy.GetComponentInChildren<TextMesh>();
            // gameMusic = boy.GetComponentInChildren<AudioSource>();
            textObject = boy.transform.FindChild("gameText");
            gameMusic = textObject.GetComponent<AudioSource>();

            if (gameMusic.name == "fruit_guyopeninggame") {

                Debug.Log(gameMusic);
                Debug.LogError("FUCK");
            }
            


            guidingText.text = "Lanza las fruitas";
            appleInstance.transform.Translate(Vector3.back *Time.deltaTime,Space.Self);
            bananaInstance.transform.Translate(Vector3.back * Time.deltaTime, Space.Self);
            if (!gameMusic.isPlaying) {
                gameMusic.Play();    
            }

            for (int i = 0; i<transform.childCount; i++) {
                //if (transform.Rotate(Vector3.up)) {
                if (transform.GetChild(i).name=="") { 

                }
            }

            //hrmmm
            //for (int i = 0; i <10 ; i++) {
                
            //}

        }
        
        superCounter++;



    }
}
