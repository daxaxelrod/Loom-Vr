using UnityEngine;
using System.Collections;

public class StartBankLogic : MonoBehaviour {

    // common counters
    private int counter = 0;
    private bool hitTrigger = false;

    //specific instances
    private EuroCounterMainOVR transactionTracker;
    private TextMesh[] BankTextMesh;
    private AudioSource BankAudioSource;
    private TextMesh gameInstructionText;
    private bool startGameTranslations = false;

    void OnTriggerEnter(Collider player)
    {
       transactionTracker = player.GetComponent<EuroCounterMainOVR>();
       hitTrigger = true;
    }

    void OnTriggerExit(Collider player) {
        hitTrigger = false;
    }
    

    // Use this for initialization
    void Start() {
        //  transactionTracker.euros;
        BankTextMesh = gameObject.GetComponentsInChildren<TextMesh>();
        // holy shit thats cool
        // instanciate is a clone() equivalent

        gameInstructionText = Instantiate(BankTextMesh[0], BankTextMesh[0].transform.position,
                            BankTextMesh[0].transform.rotation) as TextMesh;
        if (gameInstructionText != null) {
            startGameTranslations = true;
            Debug.Log("Game instruction Text has been instanciated");
        }
        // casting in unity is interesting too.
        // similar to python casting using as followed by object type

      

	}

    // Update is called once per frame
    void Update() {

        if (startGameTranslations) {
            // lets move it down to a more readable level
           
            if (counter < 120) {
                gameInstructionText.transform.Translate(new Vector3(0,-1 * Time.deltaTime, 0));
                counter++;
            }
        }

        if (hitTrigger) {
            BankTextMesh[0].text = "Teller is not available";
            BankTextMesh[1].text = "Testing Linkage";
        }
	
	}
}
