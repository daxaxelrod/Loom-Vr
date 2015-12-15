using UnityEngine;
using System.Collections;

public class npcSight : MonoBehaviour {

    public float fieldOfViewAngle = 110f;
    public bool playerInSight;
    public Vector3 personalLastSighting;

    private NavMeshAgent nav;
    private SphereCollider col;
    private Animator anim;
    // script still needs to be built
    //private LastPlayerSighting lastPlayerSighting;
    private GameObject player;
    private Animator playerAnimation;
    // need to create script
    //private HashIDs hash;
    private Vector3 previousSighting;

    void Awake() {
        nav = gameObject.GetComponent<NavMeshAgent>();
        col = GetComponent<SphereCollider>();
        anim = GetComponent<Animator>();
        // lastPlayerSighting = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<LastPlayerSighting>()
        player = GameObject.FindGameObjectWithTag("MainCamera");

        //only if we want the player to have animation components 
        //maybe in the future
        //playerAnimation = player.GetComponent<Animation>()

        // hash = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<HashIDs>();



        // need that lastPlayerSighting Script
       // personalLastSighting = lastPlayerSighting.resetPosition;
       // previousSighting = lastPlayerSighting.resetPositoin;
       
    }



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        //needs lastPlayerSighting script
        //if (lastPlayerSighting.position != previousSighting) {
        //    personalLastSighting = lastPlayerSighting;
        //    previousSighting = lastPlayerSighting.position;

        //}
        // if (playerHealth) { }

       //  player in sight param is false if player is not alive
       
	
	}

    void OnTriggerStay(Collider other) {
        if (other.gameObject == player) {
            playerInSight = false;

            Vector3 direction = other.transform.position - transform.position;
            float angle = Vector3.Angle(direction, transform.forward);

            if (angle < fieldOfViewAngle * 0.5f) {
                RaycastHit hit;
                // note that transform.up is only one unit and can be adjusted if need be
                if (Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius)) {
                    if (hit.collider.gameObject == player) {
                        playerInSight = true;
                        
                        //needs last Player sighting script
                        //lastPlayerSighting.position = player.transform.position;

                    }
                }
            }

            int playerLayerZeroStateHash = playerAnimation.GetCurrentAnimatorStateInfo(0).fullPathHash;
            int playerLayerOneStateHash = playerAnimation.GetCurrentAnimatorStateInfo(1).fullPathHash;


            //reason
            // need that hash id script
            //if (playerLayerZeroStateHash == hash.locomotionState || playerLayerOneStateHash == hash.shoutState) {
            //    if (CalculatePathLength(player.transform.position) <= col.radius) {
            //        personalLastSighting = player.transform.position;

            //    }
            //}





        }
        
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject == player) {
            playerInSight = false;
        }
    }

    // this is used for finding how long a sound has to travel
    float CalculatePathLength(Vector3 targetPosition)
    {
        NavMeshPath path = new NavMeshPath();
        if (nav.enabled) 
            nav.CalculatePath(targetPosition, path);

        Vector3[] allWayPoints = new Vector3[path.corners.Length + 2];

        //first point in array should be the enemy's posiotn

        allWayPoints[0] = transform.position;
        allWayPoints[allWayPoints.Length - 1] = targetPosition;

        for (int i = 0; i < path.corners.Length; i ++) {
            allWayPoints[i + 1] = path.corners[i];

        }

        float pathLength = 0;

        for (int i = 0; i < allWayPoints.Length - 1; i++) {
            pathLength += Vector3.Distance(allWayPoints[i], allWayPoints[i + 1]);

        }
        return pathLength;

        
    }

}
