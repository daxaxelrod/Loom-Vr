using UnityEngine;
using System.Collections;

public class OpenFencedoor : MonoBehaviour
{

    private int i = 0;
    // must set the variable at beginning of fine so it doesn't get overwritten

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {

            // in order to make it stop after turning 90 degrees
            // just add a relevant counter
            // this will not work for all computers and thus should not be used in production

            if (i < 90)
            {
                //rotate the fence post
                gameObject.transform.Rotate(new Vector3(0, i, 0) * Time.deltaTime * 2, Space.Self);
                //y you no increment

                i += 1;

                // Debug.Log(i);

            }
            else {
                if(i<127)
                gameObject.transform.Rotate(new Vector3(0,-i, 0 )*Time.deltaTime*2, Space.Self);
                i += 1;
                Debug.Log(i);
                return;
            }
                        
            //depricated
     //     if (gameObject.transform.rotation.y != 90.0 || gameObject.transform.rotation.y != 91) {  }


        }



    }

}
