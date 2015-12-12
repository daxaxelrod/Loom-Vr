using UnityEngine;
using System.Collections;

public class MoveTowardsTarget : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = gameObject.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(target.position);
	
	}
}
