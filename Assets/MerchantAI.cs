using UnityEngine;
using System.Collections;

public class MerchantAI : MonoBehaviour {

    //REFERENCE VIDEO
    //https://unity3d.com/learn/tutorials/projects/stealth/enemy-ai

    // ok toutorial has 3 things for this guy\
    // ours will have 2
    // Patrolling
    // Conversing

    public float patrolSpeed = 2f;
    public float chaseSpeed = 5f;
    public float chaseWaitTime = 5f;
    public float patrolWaitTime = 1f;
    public Transform[] patrolWayPoints;

    //to be made
    //private npcSight npcSight;
    private NavMeshAgent nav;
    private Transform player;
    // to make
    //private LastPlayerSighting lastPlayerSighting;
    private float chaseTimer;
    private float patrolTimer;
    private int wayPointIndex;
    private AudioSource clip;
    // to be made ex video tutorial
    // private PlayerBlackboard playerBlackboard;

    void Awake() {
        //See line 18,19
        //npcSight = GetComponent<EnemySight>()
        nav = GetComponent<NavMeshAgent>();

        // abstract all tags into a class and call it Tags so Tags.OVR = "MainCamera"
        player = GameObject.FindGameObjectWithTag("MainCamera").transform;
        
        // see line 22,23
        // lastPlayerSighting = GameObject.FindGameObjectWithTag("?!?!?!?!").GetComponent<LastPlayerSighting>();

        //see line 29,30
        // playerBlackBoard = player.getComponent<PlayerBlackboard>();

            }
    



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //this is rule based AI



        // introducing new thing here
        //player blackboard. thanks game ai pro
        if (false) //npcSight.playerInSight != lastPlayerSighting.resetPosition && playerBlackboard //this goes in if when done 
        {
            AppproachAndSpeak();
        }
        else {
            //use to be patrolling from video
            MeanderingAbout();
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
 //       Vector3 sightingDeltaPos = enemySight.personalLastSighting - transform.position;

        // something about a small margin ***COME BACK** sqrMag makes sense though
 //       if (sightingDeltaPos.sqrMagnitude > 4f) {

//            nav.destination = enemySight.personalLastSighting;
            nav.speed = chaseSpeed;

            //GOTTA start the audio here
            //randomize the audio. can i do that?
            // yes i can just not without the audio library
            clip = gameObject.GetComponent<AudioSource>();
            if (!clip.isPlaying) {
                clip.Play();
            }
            
 //       }

        //SUPER IMPORTANT FOR TIME LOGIC
        //this handles how long one has been chased

        if (nav.remainingDistance < nav.stoppingDistance)
        {
            //brilliant
            chaseTimer += Time.deltaTime;

            if (chaseTimer > chaseWaitTime) {
                // here we retrun the npc back to the conditions nessesary for seeing the player again
                // esentially clearing the chache
 //            //   lastPlayerSighting.position = lastPlayerSighting.resetPosition;
 //            //   enemySight.personalLastSighting = lastPlayersighting.resetPosition;

                chaseTimer = 0f;

            }
        }
        else {
            chaseTimer = 0f;
            
        }


    }

    void MeanderingAbout() {
        // follows the same logic as the approach part of Approach and speech
        nav.speed = patrolSpeed;
//        if (nav.destination == lastPlayerSighting.restPosition || nav.remainingDistance < nav.stoppingDistance){
            patrolTimer += Time.deltaTime;

            if (patrolTimer >= patrolWaitTime)
            {
                if (wayPointIndex == patrolWayPoints.Length - 1)
                {
                    wayPointIndex = 0;

                }
                else
                {
                    wayPointIndex++;
                }
                patrolTimer = 0f;
            }
        //}
        //else { patrolTimer = 0f;}

        nav.destination = patrolWayPoints[wayPointIndex].position;
        

    }


}
