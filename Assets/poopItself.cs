using UnityEngine;
using System.Collections;

public class poopItself : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if(gameObject.transform.position.y >= 0) { 
        gameObject.transform.Translate(new Vector3(0,-1,0)*Time.deltaTime, Space.Self);
        }
    }
}
