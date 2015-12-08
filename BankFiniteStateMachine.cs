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
            Debug.LogError("FSM had a pretty bad error" + stateID.ToString() + " Already has a transition"
                +trans.ToString() + " Impossible to assign to another state");
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

public class FSMSystem {
    private List<FSMState> states;

    // tje only way one can change the state of the fsm is by performing a transition
    // *** DO FUCKING NOT *** change the current state directly 
    private StateID currentStateID;
    public StateID CurrentStateID { get { return currentStateID; } }// pay attention to caps here
    private FSMState currentState;
    public FSMState CurrentState { get { return currentState; } }

    public FSMSystem() {
        states = new List<FSMState>();
    }

    // this method adds new states inside Fsm
    // or shoots out errors left and right if the stae was already inside the list
    // first state added is also the initial state

    public void AddState(FSMState s) {
        if (s == null) {
            Debug.LogError("ERROR BROS. null reference is not allowed");
        }
        // first state inserted is also the inital state
        // think the root state
        // the state when the machine begins\
        if (states.Count == 0) {

            states.Add(s);
            currentState = s;
            currentStateID = s.ID;
            return;

        }
        // add state to the list of states if its not there already
        foreach (FSMState state in states) {
            if (state.ID == s.ID) {
                Debug.LogError("FSM error. Impossible to add state " + s.ID.ToString() + " because state has already been added");
                return;
            }

        }
        states.Add(s);

    }

    // next method deletes a state from FSM list if it already exists
    // or prints an error message if the state should exist but doesnt.

    public void DeleteState(StateID id) {
        // check if its a null state
        // if so, someone fucked up, make sure that the state is instanciated at some point if you want to delete it
        if (id == StateID.NullStateID) {
            Debug.LogError("FSM error, the id passed in is not a real state");
            return;
        }
        foreach (FSMState state in states) {
            if (state.ID == id) {
                states.Remove(state);
                return;
            }
        }
        Debug.LogError("FRM error. impossible to delete state " + id.ToString() + ". it was not in the list of states.");


    }

    // next method tries to chage the state the fsm is in based on the current state 
    //and the transition passed in. If the current state doesnt have a target state for the transition passed,
    // prints an error message
    public void PerformTransition(Transition trans) {
        if (trans == Transition.NullTransition) {
            Debug.LogError("FSM error, NullTransition is not allowed for a real transition");
            return;
        }
        // look at current state
        // see if it has the transition passed as an argument
        StateID id = currentState.GetOutputState(); // using method created above
        if (id == StateID.NullStateID) {
            Debug.LogError("FSM ERROR: State " + currentStateID.ToString() + " does not have a target state " +
                           " for transition " + trans.ToString());
            return;

        }
        // update the currentStateID and the currentState
        currentStateID = id;
        foreach (FSMState state in states) {
            if (state.ID == currentStateID) {
                // post processes to do to the state before setting a new one
                currentState.DoBeforeLeaving();
                currentState = state;

                // reset the state to its condition before is can be enacted (reasoning steps included)
                currentState.DoBeforeEntering();
                break;
            }

        } // performTranition()

    } // class FSMSystem()
    // holy fuck done










































}
























