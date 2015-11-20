using UnityEngine;
using System.Collections;

public class translateBasedOnLanguageType : MonoBehaviour {
    //several ideas here. Link to google translate api
    //find what language the user wants. To be built
    // store all texts in textmeshes into large array
    // maybe all of the sound clips? no idea
    // then let google rip on them.
    // set the current text mesh to the language that google provided
    private TextMesh[] gameStringSet;


    //test
    public string testWord = "hello";


	// Use this for initialization
	void Start () {
        gameStringSet = GameObject.FindObjectsOfType<TextMesh>();
        foreach (TextMesh stringToTranslate in gameStringSet) {
           string temp = stringToTranslate.text;
            

            
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
