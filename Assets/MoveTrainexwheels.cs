using UnityEngine;
using System.Collections;

public class MoveTrainexwheels : MonoBehaviour {

    private int trainForce = 50;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            gameObject.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * trainForce);
         //   gameObject.get
        }

	}
}
/*
public static class Helper { 

    public static T FindComponentInChildWithTag<T>(this GameObject parent, string tag)
    {
    Transform t = parent.transform;
    foreach (Transform tr in t)
    {

            if (tr.tag == tag)
            {
                return tr.GetComponent<T>();

            }
            //what can we return here?

            else return; 


    }
}

}*/

