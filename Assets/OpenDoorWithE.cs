using UnityEngine;
using System.Collections;





    public class OpenDoorWithE : MonoBehaviour
    {
        public bool doorOpenable;

        int onlyOnce = 0;




        // Use this for initialization
        void Start()
        {

            //
            // bool doorOpenable = false; // does it have to be here? or up before initialize?



            // int setAxis = 100;
        }

        // Update is called once per frame
        void Update()
        {
        //  ScriptableObject
        //panderiaTrigger triggervar = new panderiaTrigger();

        // Debug.Log(triggervar.allowDoorOpen + "triggarvar");
        // if (triggervar.allowDoorOpen)
            if(Input.GetKey(KeyCode.E))
        {

            if (GetComponent<AudioSource>() != null)
            {
                if (onlyOnce <= 1)
                {
                    GetComponent<AudioSource>().Play();
                    onlyOnce++;
                }
            }
               // Debug.Log("got through first if");
                if (gameObject.transform.position.y >= -10)
                {
                    //lolz needs work
                    Debug.Log("got through second if. Hit this at all?");
                    transform.RotateAround(new Vector3(-18, 0, 0), new Vector3(-17, 1, -22), Time.deltaTime * -100);
                }
                else
                {
                
                }
            }
        }
    }

