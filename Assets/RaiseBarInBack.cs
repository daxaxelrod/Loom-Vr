using UnityEngine;
using System.Collections;

public class RaiseBarInBack : MonoBehaviour {

    [SerializeField]
    private Camera camera;
    //      public ParticleEmitter emmiter;
    private Ray ray;
    // Use this for initialization
    void Start()
    {
        // we are not using a particle emmiter. whoops
        //   emmiter = (ParticleEmitter) Instantiate( emmiter, transform.position, Quaternion.identity);


        RaycastHit hit;
        ray = camera.ScreenPointToRay(Vector3.forward);
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log(string.Format("You hit {0} jackass", objectHit.name.ToString()));
            //objectHit.Translate(new Vector3(0, 15 * Time.deltaTime, 0));

            Transform playerCube = gameObject.transform.GetChild(0);
            if (playerCube != null ) { }
            playerCube.localScale.Set(100f, 0, 0);

        }
    }
        // Update is called once per frame
        void Update () {
        //for (int i = 0; i < 2; i++) {

        //}

        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 10f);
        
	}
}
