using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.Timers;


// never seen this before
// learn something new everyday
[RequireComponent(typeof(Rigidbody))]
public class NPCControl : MonoBehaviour {

    public GameObject ovrPlayer;
    public Transform[] path;
    private FSMSystem fsm;
    // why the fuck is this not hitting?

    //private void SetTransition(Transition t) {
    //    fsm.PerformTransition(t);
    //  //  throw new NotImplementedException();
    //}
    internal void SetTransition(Transition t)
    {
        fsm.PerformTransition(t);
       // throw new NotImplementedException();
    }


    // Use this for initialization
    void Start () {
        MakeFSM();
	}

    public void FixedUpdate()
    {
        fsm.CurrentState.Reason(ovrPlayer, gameObject);
        fsm.CurrentState.Act(ovrPlayer, gameObject);
    }

    // alright now time to set up the states to be used in state
    // the NPC has two state, FollowPrePath and ChasePlayer <<== were pre path stands for predetermined path
    // if its on the first state and SawPlayer transition is fired, it changes to ChasePlayer
    // if its on ChasePlayerState and LostPlayer transition is fired, it returns to FollowPrePath 

    private void MakeFSM()
    {
        FollowPathState follow = new FollowPathState(path);
        follow.AddTransition(Transition.SawPlayer, StateID.ChasingPlayer);

        ChasePlayerState chase = new ChasePlayerState();
        chase.AddTransition(Transition.LostPlayer, StateID.FollowPath);

        fsm = new FSMSystem();
        fsm.AddState(follow);
        fsm.AddState(chase);

    }
    
	// Update is called once per frame
	void Update () {
	
	}

  
}

public class FollowPathState : FSMState
{
    private int currentWayPoint;
    private Transform[] waypoints;

    public FollowPathState(Transform[] wp) {
        waypoints = wp;
        currentWayPoint = 0;
        stateID = StateID.FollowingPath;
    }

    public override void Reason(GameObject player, GameObject npc)
    {
        RaycastHit hit;
        // if the player passes less than 10 meters away in front of the NPC
        // raycasting is analagous to shooting a gun in cod
        // this is the logic for seeing the player 
        // also sets it at a transition
        if (Physics.Raycast(npc.transform.position, npc.transform.forward, out hit, 10f)) {
            if (hit.transform.gameObject.tag == "MainCamera") {
                npc.GetComponent<NPCControl>().SetTransition(Transition.SawPlayer);
            }// bracket all logic, unless crazy exceptions

        }


        // throw new NotImplementedException();
    }

    public override void Act(GameObject player, GameObject npc)
    {
        // Follow the path of waypoints
        // Find the direction of the current way point 
        Vector3 vel = npc.GetComponent<Rigidbody>().velocity; // what the fuck?? why wont you give me velocity
        Vector3 moveDir = waypoints[currentWayPoint].position - npc.transform.position;
        //follow the path of the waypoints
        // find the direction of the current waypoint

        if (moveDir.magnitude < 1)
        {
            currentWayPoint++;
            if (currentWayPoint >= waypoints.Length)
            {
                currentWayPoint = 0;
            }

        }
        else {
            vel = moveDir.normalized * 10;

            //rotate towards the waypoint       //Slerp()?!?!?!?
            npc.transform.rotation = Quaternion.Slerp(npc.transform.rotation,
                                                    Quaternion.LookRotation(moveDir),
                                                    5 * Time.deltaTime);
            npc.transform.eulerAngles = new Vector3(0, npc.transform.eulerAngles.y, 0);
            
        }



        npc.GetComponent<Rigidbody>().velocity = vel;
        
        // throw new NotImplementedException();
    }

} // end of FollowPathState

public class ChasePlayerState : FSMState
{
    public ChasePlayerState()
    {
        stateID = StateID.ChasingPlayer;
    }
    public override void Reason(GameObject player, GameObject npc)
    {
        // throw new NotImplementedException();
        // if the player is further than 20 meters away, fire LostPlater transition
        if (Vector3.Distance(npc.transform.position, player.transform.position) >= 20) {
            npc.GetComponent<NPCControl>().SetTransition(Transition.LostPlayer);

        }
    }
    public override void Act(GameObject player, GameObject npc)
    {
        // follow the path of the waypoints
        // find the direction of the player
        Vector3 vel = npc.GetComponent<Rigidbody>().velocity;
        Vector3 moveDir = player.transform.position - npc.transform.position;

        //rotate towards the player
        npc.transform.rotation = Quaternion.Slerp(npc.transform.rotation,
                                                    Quaternion.LookRotation(moveDir),
                                                    5 * Time.deltaTime);
        //apply eurler angles
        npc.transform.eulerAngles = new Vector3(0, npc.transform.eulerAngles.y, 0);

        
        vel = moveDir.normalized * 10;

        // apply the new velocity
        npc.GetComponent<Rigidbody>().velocity = vel;

        // throw new NotImplementedException();
    }

} // end of ChasePlayerState

















































