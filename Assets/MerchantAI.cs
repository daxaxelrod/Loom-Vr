using UnityEngine;
using System.Collections;

public class MerchantAI : MonoBehaviour {

    //REFERENCE VIDEO
    //https://unity3d.com/learn/tutorials/projects/stealth/enemy-ai

    // ok toutorial has 3 things for this guy\
    // ours will have 2
    // Patrolling
    // Conversing

    public float patrolSpeed = 200f;
    public float chaseSpeed = 50f;
    public float chaseWaitTime = 5f;
    public float patrolWaitTime = 1f;
    public Transform[] patrolWayPoints;

    //to be made
    private npcSight npcSight;
    private NavMeshAgent nav;
    private GameObject player;
    private Transform playerTransform;
    // to make
    private lastPlayerSighting lastPlayerSighting;
    private float chaseTimer;
    private float patrolTimer;
    private int wayPointIndex;
    private AudioSource clip;
    // to be made ex video tutorial // almost there
     private PlayerBlackboard playerBlackboard;

    void Awake() {
        //See line 18,19 // all good now
        npcSight = GetComponent<npcSight>();
        nav = GetComponent<NavMeshAgent>();

        // abstract all tags into a class and call it Tags so Tags.OVR = "MainCamera"
        player = GameObject.FindGameObjectWithTag("MainCamera");
        playerTransform = player.transform;
        
        // see line 22,23 // all good now
         lastPlayerSighting = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<lastPlayerSighting>();

        //fuck still need player blackboard
        //see line 29,30 //made but needs work
        playerBlackboard = player.GetComponent<PlayerBlackboard>();
            }
    



    // Use this for initialization
    void Start () {
        // print("Everyone wants to get in on the action.");
        Debug.Log("Joe can go fuck himself");
    }
	
	// Update is called once per frame
	void Update ()
    {
        //this is rule based AI



        // introducing new thing here
        //player blackboard. thanks game ai pro
        if (npcSight.playerInSight && playerBlackboard)  //this goes in if when done // fucking woot // != lastPlayerSighting.resetPosition << this isnt needed as it is a vector3
        {
            AppproachAndSpeak();
            Debug.Log("Stop walking and speak to me");
        }
        else {
            //use to be patrolling from video
            MeanderingAbout();
           // Debug.Log("the guy should be walking around");
        }
        
	}
    // no shooting
    //learned something new --> nav mesh agent has a usful stop function that stops the agent in its tracks

    // no chasing function



    void AppproachAndSpeak() {

        // set a destination of the last personal sighting of the player by the npc
        // but only if distance is less than 1/5 of the plaza

        // position of the player minus the position of the npc yeilds the distance.
        // could also use the distance function
        Vector3 sightingDeltaPos = npcSight.personalLastSighting - transform.position;

        // something about a small margin ***COME BACK** sqrMag makes sense though
       if (sightingDeltaPos.sqrMagnitude > 4f) {

            nav.destination = npcSight.personalLastSighting;
            nav.speed = chaseSpeed;

            //GOTTA start the audio here
            //randomize the audio. can i do that?
            // yes i can just not without the audio library
            clip = gameObject.GetComponent<AudioSource>();
            if (clip != null) {
                if (!clip.isPlaying) {
                    clip.Play();
                }
            }
            
        }

        //SUPER IMPORTANT FOR TIME LOGIC
        //this handles how long one has been chased

        if (nav.remainingDistance < nav.stoppingDistance)
        {
            //brilliant
            chaseTimer += Time.deltaTime;

            if (chaseTimer > chaseWaitTime) {
                // here we retrun the npc back to the conditions nessesary for seeing the player again
                // esentially clearing the chache
                lastPlayerSighting.position = lastPlayerSighting.resetPosition;
                npcSight.personalLastSighting = lastPlayerSighting.resetPosition;

                chaseTimer = 0f;

            }
        }
        else {
            chaseTimer = 0f;
            
        }


    }

    void MeanderingAbout() {

        //whoops didnt need to comment out. old code was fine

        // follows the same logic as the approach part of Approach and speech
        //nav.speed = patrolSpeed;

        //    // if the guy is near the next waypoint or there is no destination
        //    if (nav.destination == lastPlayerSighting.resetPosition || nav.remainingDistance < nav.stoppingDistance){
        //    patrolTimer += Time.deltaTime;

        //    if (patrolTimer >= patrolWaitTime)
        //    {
        //        if (wayPointIndex == patrolWayPoints.Length - 1)
        //        {
        //            wayPointIndex = 0;

        //        }
        //        else
        //        {
        //            wayPointIndex++;
        //        }
        //        patrolTimer = 0f;
        //    }
        //}
        //else { patrolTimer = 0f;}

        //nav.destination = patrolWayPoints[wayPointIndex].position;

        nav.stoppingDistance = 1.2f; // original is 0.8

        // Set an appropriate speed for the NavMeshAgent.
        nav.speed = patrolSpeed;

        if (nav.speed <= chaseSpeed) {
            nav.speed = 100f; // do me a favor and dont hard code this for the future
        }

        // If near the next waypoint or there is no destination...
        if (nav.destination == lastPlayerSighting.resetPosition || nav.remainingDistance < nav.stoppingDistance)
        {
            // ... increment the timer.
            patrolTimer += Time.deltaTime;

            // If the timer exceeds the wait time...
            if (patrolTimer >= patrolWaitTime)
            {
                // ... increment the wayPointIndex.
                if (wayPointIndex == patrolWayPoints.Length - 1)
                    wayPointIndex = 0;
                else
                    wayPointIndex++;

                // Reset the timer.
                patrolTimer = 0;
            }
        }
        else
            // If not near a destination, reset the timer.
            patrolTimer = 0;

        // Set the destination to the patrolWayPoint.
        nav.destination = patrolWayPoints[wayPointIndex].position;
       // Debug.Log(nav.destination);


    }


}
// waypoint 0 through 4 is for the first npc

// waypoint 5 through 10 is for the second npc