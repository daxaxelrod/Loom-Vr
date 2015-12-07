using UnityEngine;
using System.Collections;

public class StartBankLogic : MonoBehaviour {

    private EuroCounterMainOVR transactionTracker;
    private TextMesh BankTextMesh;
    private AudioSource BankAudioSource;
    
    void OnTriggerEnter(Collider player)
    {
       transactionTracker = player.GetComponent<EuroCounterMainOVR>();
    }

	// Use this for initialization
	void Start () {
       //  transactionTracker.euros;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
