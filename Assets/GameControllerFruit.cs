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

    private GameObject[] barrel;
    private Rigidbody barrelBody;
    private float barrelAcceleration = .5f;
    private float maxBarrelSpeed = 5;

    private GameObject[] crate;
    private Rigidbody crateBody;
    private float crateAcceleration = 1.0f;
    private float maxCrateSpeed = 8;


    private void transformBarrel(float a, float b, float c, int barrelNumber)
    {
        barrelAcceleration = 0;
        barrel[barrelNumber].transform.Translate(a, b, c);
        if (barrelAcceleration < maxBarrelSpeed)
        {
            barrelAcceleration += .5f;
        }
        return;

    }

    private void transformCrate(float a, float b, float c, int crateIndex) {
        crateAcceleration = 0;
        crate[crateIndex].transform.Translate(a, b, c);
        if (crateAcceleration < maxCrateSpeed)

    }


    // Use this for initialization
    void Start () {
            if(appleInstance == null) {
            appleInstance = GameObject.FindGameObjectWithTag("AppleGrouping1");
            }

            if (bananaInstance == null)
            {
            bananaInstance = GameObject.FindGameObjectWithTag("BananaGrouping1");
            }
        barrel = GameObject.FindGameObjectsWithTag("barrel");
        Debug.Log(barrel);

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

        if (superCounter < 225){

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
            // for (int i = 0; i < bananaInstance.Length; i++) {

            //    bananaInstance[i].transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime, Space.Self);

            //}

            boy.transform.Translate(new Vector3(-.5f, 0, 0) * Time.deltaTime, Space.Self);

        }
        if (superCounter > 225 && superCounter < 500 ) {
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
            appleInstance.transform.Translate(Vector3.back * Time.deltaTime, Space.Self);
            bananaInstance.transform.Translate(Vector3.back * Time.deltaTime, Space.Self);
            if (!gameMusic.isPlaying) {
                gameMusic.Play();    
            }


            //barrelindex
            // 0 is the left most one 
            // 1 is the topmost right
            // 2 is the topmost left







            if (superCounter < 390) {
                //barrelBody = barrel.GetComponent<Rigidbody>();
                //barrel.transform.Translate(-barrelAcceleration * Time.deltaTime / 4, 0, 0);
                //if (barrelAcceleration < maxBarrelSpeed) {
                //barrelAcceleration += .5f;
                //}
                transformBarrel(-barrelAcceleration *2 * Time.deltaTime, 0, 0,1);
            }
            if (superCounter > 390 && superCounter < 450) {
                transformBarrel(0, -barrelAcceleration * 4.8f * Time.deltaTime , 0, 1);
                //barrelAcceleration = 0;
                //barrel.transform.Translate(0, -barrelAcceleration * Time.deltaTime / 4, 0);
                //if (barrelAcceleration < maxBarrelSpeed) {
                //    barrelAcceleration += .5f;
                //}
                
                //subtract from the z of barrel 2
                transformBarrel(0,0,-barrelAcceleration * 3f * Time.deltaTime, 2);
                

            }
            // 2nd stage
            

            //2.1 stage
            //fuck
            if (superCounter > 450 && superCounter < 550) {
                transformBarrel(-.5f, 0, 0, 3);
                // transformBarrel(-barrelAcceleration, -.25f ,0, 2);
                transformBarrel(0, 0, -barrelAcceleration *4 * Time.deltaTime , 4);
                transformBarrel(barrelAcceleration*12*Time.deltaTime, 0,0,2);
                transformBarrel((-barrelAcceleration * 5 / 4), 0, 0, 1);

            }
            if (superCounter >  550 && superCounter < 650) {
                //transformBarrel(0,-barrelAcceleration* 2 *Time.deltaTime, 100 ,2);
                transformBarrel(barrelAcceleration* Time.deltaTime* 2,0,0,2);
                // barrel 2 down needs to happen after x translataion
                //   transformBarrel(0,-barrelAcceleration * 5f * Time.deltaTime, 0, 2); // moves the 2nd barrel forward
            
                transformBarrel(-barrelAcceleration, 0, 0, 2);
            }

            if (superCounter > 950) {
                //transformBarrel(0,0,-barrelAcceleration*Time.deltaTime*2 ,0);
            }
           


            // Debug.Log(barrelBody);
            // barrelBody.AddForce(new Vector3(0,10,10), ForceMode.Acceleration);
            //barrel.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1)); //adds force for 
            //                                                        // to the barrels

            //for (int i = 0; i<transform.childCount; i++) {
            //    //if (transform.Rotate(Vector3.up)) {
            //    if (transform.GetChild(i).name=="barrel") {

            //    }
            //}

            //hrmmm
            //for (int i = 0; i <10 ; i++) {

            //}
        }
        
        superCounter++;
   


    }



}
