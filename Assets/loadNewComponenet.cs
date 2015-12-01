using UnityEngine;
using System.Collections;

public class loadNewComponenet : MonoBehaviour {

    private bool enteredTrigger = false;
    private bool preventReload = true;
	// Use this for initialization
	void Start () {
	
	}

    public void OnTriggerEnter(Collider player){
        Debug.Log("load the new scene bitch");
        enteredTrigger = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (enteredTrigger && preventReload)
        {
            Application.LoadLevelAdditiveAsync(5);
            preventReload = false;
        }
        
	
	}
}
