using UnityEngine;
using System.Collections;

public class lastPlayerSighting : MonoBehaviour {

    public Vector3 position = new Vector3(1000f, 1000f, 1000f); // customize this a bit
    public Vector3 resetPosition = new Vector3(1000f,1000f,1000f); // this too
    //actually maybe no customization is needed because as long as those values are unreachable, we are ok

    public float lightHighIntensity = 0.25f;
    public float lightLowIntensity = 0f;
    public float fadeSpeed = 7f;


    private Light mainLight;

    void Awake()
    {
        mainLight = GameObject.FindGameObjectWithTag(Tags.mainLight).GetComponent<Light>();


    }
	// Update is called once per frame
	void Update () {
	
	}
}
