using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Transition
{
	NullTransition = 0,
}

public enum StateID
{
    NullStateID = 0,
}

public abstract class FSMState
{
    protected Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();
    protected StateID stateID;
    public StateID ID { get { return stateID; } }

    public void AddTransition(Transition trans, StateID id) {

        //first step of the fsm
        //check the args and see if they are invalid
        if (trans == Transition.NullTransition) {
            Debug.LogError("FSM had a pretty bad error.  Null transition is not allowed for a real tranisition. \n You have a shit ton of work david");
            return;

        }

        if (id = StateID.NullStateID) {
            Debug.LogError("FSM had a pretty bad error. Null STATE id is not allowed for a real ID");
            return;
        }


        // deterministic FSM 
        //      check if current transition was already inside the map

        if (map.ContainsKey(trans)) {
            // fuck, if this hits ive hit a transition that already has a transition

            //   Enum enumerations = RuntimeTypeHandle.ReferenceEquals(StateID);
            Debug.LogError("FSM had a pretty bad error" + stateID.ToString() + " Already has a transition" + trans.
                () + " Impossible to assign to another state");
            return;

        }
        map.Add(trans, id);
        
    }

    public void DeleteTransition(Transition trans)
    {
        // have to check if the transition is null or not.
        // cant delete a null transition
        if (trans == Transition.NullTransition) {
            Debug.LogError("FSM had a pretty bad error. NullTrasition not allowed for a real transition");
            return;
        }

        if (map.ContainsKey(trans)) {
            map.Remove(trans);
            return;
        }

        Debug.LogError("FSMState ERROR: Transition " + trans.ToString() + " passed to " + stateID.ToString() +
                      " was not on the state's transition list");
        
    }


    // THIS ONE IS FUCKING IMPORTANT
    // ... they all are, no bugs boys
    // famous last words

    // This method returns the new state the FSM should be if
    //    this state receives a transition 
    public StateID GetOutputState(Transition trans) {
        // check if the map contains transition
        if (map.ContainsKey(trans)) {
            return map[trans];
        }
        return StateID.NullStateID;
        
    }
    
    // This method is used to set up the State condition before entering it.
    // It is called automatically by the FSMSystem class before assigning it
    // to the current state.
    
    public virtual void DoBeforeEntering() { }

    
    // This method is used to make anything necessary, as reseting variables
    // before the FSMSystem changes to another one. It is called automatically
    // by the FSMSystem before changing to a new state.
    
    public virtual void DoBeforeLeaving() { }

    
    // This method decides if the state should transition to another on its list
    // NPC is a reference to the object that is controlled by this class
    
    public abstract void Reason(GameObject player, GameObject npc);
    
    // This method controls the behavior of the NPC in the game World.
    // Every action, movement or communication the NPC does should be placed here
    // NPC is a reference to the object that is controlled by this class

    public abstract void Act(GameObject player, GameObject npc);

    


} // end the abstract, start the actual finite state machine
//lolz its at this point where i wonder if this should be a behavoiral tree
// fuck it, lets know about both

    // the finite state machine class is represented by FSMSystem

