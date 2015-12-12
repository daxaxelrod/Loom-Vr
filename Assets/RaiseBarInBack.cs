using UnityEngine;
using System.Collections;

public class RaiseBarInBack : MonoBehaviour {

    [SerializeField]
    public ParticleEmitter emmiter;

	// Use this for initialization
	void Start () {
        emmiter = (ParticleEmitter) Instantiate( emmiter, transform.position, Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < 2; i++) {

        }
	
	}
}
