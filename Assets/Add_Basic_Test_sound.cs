using UnityEngine;
using System.Collections;

public class Add_Basic_Test_sound : MonoBehaviour
{

    private bool panaderiaStartSpeaking = false;

    AudioSource[] audios;
    // Use this for initialization
    void Start()
    {
         audios = GetComponents<AudioSource>();
        //Debug.Log()

    }
    //yo this isnt working. maybe wrong method. check doortrigger.cs
    void OnTriggerEnter(Collider camera){
        //big difference between collision and collider
        camera.gameObject.transform.Translate(Vector3.up);

        Debug.Log(panaderiaStartSpeaking);
        // if (Input.GetKey(KeyCode.Comma))
        if (camera.gameObject.name == "girl")
        {
            
            audios[0].Play();
            float timeDelay = 5;
            for (int audioPos = 1; audioPos < audios.Length; audioPos++)
            {
                timeDelay += audios[audioPos].time;
                //wow that works well
                //basically can add as many audios to this as you want and it will play them one after another
                audios[1].PlayDelayed(timeDelay);
            }

        }


        //  Debug.Log("IT WORRRRRKKKKKSSSSSS");
    }


    //triggers are global collisions are local
    //void OnTriggerStay(Collider camera) {
     //   panaderiaStartSpeaking = true;    }

    //void OnTriggerExit(Collider camera) {
        // play the adois sound
    //    panaderiaStartSpeaking = false;    }

















    // Update is called once per frame

}
