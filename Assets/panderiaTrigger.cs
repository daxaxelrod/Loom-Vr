using UnityEngine;
using System.Collections;

namespace panderiaTrigger
{

    
public class panderiaTrigger : MonoBehaviour
    {
        private OpenDoorWithE openDoorWithE;

        private Color black = new Color(0, 0, 0, 1);
        private bool hitTrigger = false;
        // private GameObject openDoorWithE;




        // depricated
        // public bool allowDoorOpen = false;



        //triggers are not updated once per frame....should they?
        //no fucking clue david
        // thanks david
        void OnTriggerEnter(Collider otherTingYouHitMan)
        {
            Debug.Log("Object Entered the panderia trigger");
            hitTrigger = true;
            
            //depricated
            // allowDoorOpen = true;

        }


        void OnTriggerStay(Collider otherTingYouHitMan)
        {
            //Debug.Log("Still here?");
            // if (hitTrigger) { hitTrigger = false; }
            //else { hitTrigger = true; }
            return;
        }

        void OnTriggerExit(Collider otherTingYouHitMan)
        {
            Debug.Log("Oh good you left. Ta ta for now");
            hitTrigger = false;
            return;
             
        }







        // Use this for initialization
        void Start()
        {
            //this works
            openDoorWithE = GetComponent<OpenDoorWithE>();
            //this does not
            //fuck

            //Debug.Log(openDoorWithE.enabled);
           
            //Debug.Log(openDoorWithE.enabled);



        }

        // Update is called once per frame
        void Update()
        {
            // ok this is going to be really inefficiant but it might work

            //FUCK JUST GAVE A DEMO AND THE SCIPTS ARE NOT WORKING!!!
            //LOL
            //IM DRUNK
            // openDoorWithE  = gameObject.GetComponent("Open Door With E");


            //update new game object here

            if (hitTrigger)
            {


                //gameObject.AddComponent();

                openDoorWithE.enabled = true;

                try
                {
                    TextMesh meshDoorText = gameObject.GetComponentInChildren<TextMesh>();

                    meshDoorText.text = "Open Door with E";
                    Debug.Log(meshDoorText.text);
                }
                catch {
                    //null reference exception
                    Debug.LogError("Error with the mesh text bro");
                    return;
                }




                // TODO 
                //1) create 1 new 3d text node saying press e to open door
                //2) allow e to actually open the door by just pressing it once


                //TextMesh doorTextMesh = gameObject.AddComponent<TextMesh>();

                //doorTextMesh.text = "HI I HOPE THIS WORKS OMG OMG OMG";

                //gameObject.GetComponent < GUIText > = "Hello again"; //goodbye


                //now that we've learned a bit heres the plan
                //1.1 create sub game object on door using transform
                //1.2 set mesh text to that new object
                //1.3 ??????????
                //1.4 profit

                GameObject doorSubObject = new GameObject();
                //doorSubObject.name = "Prompt Text";

                //sets parent                   to door ^_^    step one done
                doorSubObject.transform.parent = gameObject.transform;
                //have the sub object be in the exact same pos as gameobject
              

                //TextMesh doorTM = new TextMesh();

                // add to doorsubobject
                doorSubObject.AddComponent<TextMesh>();
                //create textmesh and set text
                TextMesh doorTM = doorSubObject.GetComponent<TextMesh>();
                doorTM.text = "Press E to open door";
                doorTM.color = black;


                


    

               // Debug.Log(doorSubObject.transform.position.x);
               // Debug.Log(doorSubObject.transform.position.y);
               // Debug.Log(doorSubObject.transform.position.z);



                //set position AFTER everything else
                doorSubObject.transform.position = new Vector3(4.1f,
                                                               1.04f,
                                                                -.72f);

                Debug.Log(doorSubObject.transform.position.x);
                Debug.Log(doorSubObject.transform.position.y);
                Debug.Log(doorSubObject.transform.position.z);
               
                //rotate y to -90
                doorSubObject.transform.Rotate(new Vector3(0, -90));
                //scale x to .5
                doorSubObject.transform.lossyScale.Set(.5f, .13568f, .32527f);



                if (doorSubObject.GetComponent<TextMesh>().text == "Press E to open door")
                {
                    //Debug.Log("Text matches text set in creation. Hip hip horrayyyyy!!");

                }


                /*  if (doorSubObject.transform.parent != null) {
                      Debug.Log("TEst compleeeteee");
                          }
                */





                //note to self, didnt work 1st try... sigh.... welp lets go again
                //if (doorTextMesh != null)
                // {
                //  Debug.Log("Its here somewhere.... Where are you mr textmesh");
                //}

            }


        }
    }
}