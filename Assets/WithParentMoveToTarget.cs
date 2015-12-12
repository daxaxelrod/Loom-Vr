using UnityEngine;
using System.Collections;

public class WithParentMoveToTarget : MonoBehaviour {

    [SerializeField]
    private GameObject parentBitch;

    [SerializeField]
    private Transform target;

    // POSSIBLE FOR MULTI TARGETED PATHFINDING
    //[SerializeField]
    //private Transform[] target;
    //private int x;



    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = gameObject.GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {
        // x = target.GetLength(0);
        // for () { }
        agent.SetDestination(target.position);
        // NOTE updated position take the current position of the angent
        //parentBitch.transform.position = gameObject.transform.position;
    }
    //void FixedUpdate()
    //{
        
    //    parentBitch.transform.position = gameObject.transform.position;
    //}

}
