using UnityEngine;
using System.Collections;

public class bankenterTrigger : MonoBehaviour {
    private GameObject bankDoor;
    private float turnSpeed = 5;

    private int bankCounter = 0;
  
    // Use this for initialization
    void OnTriggerEnter(Collider player) {
        openDoorAndLoadBankGame();
        Debug.Log("Bank Trigger entered");
        bankCounter += 1;
    }


    void Start()
    {
       bankDoor = GameObject.FindGameObjectWithTag("BankDoor");
    }
    
	// Update is called once per frame
	void Update () {
        Debug.Log(bankCounter);
        }

 

    public void openDoorAndLoadBankGame()
    {
        if (bankCounter == 1) {
            new WaitForSeconds(4);
            Application.LoadLevel(3);
            Debug.Log("Loading new level");
        }
        //open the door and pull the trigger after the animation ends
        bankDoor.transform.Rotate((new Vector3(8.07f, -11.33f, -4.99f)), turnSpeed * Time.deltaTime);

        //need to work on rotations

    }


}
