using UnityEngine;
using System.Collections;
// using BankFiniteStateMachine;

public class StartBankLogic : MonoBehaviour {

    // common counters
    private int counter = 0;
    private bool hitTrigger = false;
    private float eurosInAccount = 0.00f;

    //specific instances
    private EuroCounterMainOVR transactionTracker;
    private TextMesh[] BankTextMesh;
    private AudioSource BankAudioSource;
    private GameObject gameInstructionText;
    private bool startGameTranslations = false;
    private GameObject mainCamera;

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
                            BankTextMesh[0].transform.rotation) as GameObject;
        if (gameInstructionText != null) {
            startGameTranslations = true;
            Debug.Log("Game instruction Text has been instanciated");
        }
        // casting in unity is interesting too.
        // similar to python casting using as followed by object type



        //main camera for gestur analysis
       // mainCamera = GameObject.FindGameObjectWithTag("mainCamera");
      

	}

    // Update is called once per frame
    void Update() {
        Debug.Log(hitTrigger);
        if (startGameTranslations) {
            // lets move it down to a more readable level
               
            if (counter < 120) {
                gameInstructionText.transform.Translate(new Vector3(0,-1 * Time.deltaTime, 0));
                counter++;
            }
        }

        if (hitTrigger) {
            string euros = eurosInAccount.ToString();
            BankTextMesh[0].text = "Teller is not available";
            BankTextMesh[1].text = "Hi! I'm tobius, the Automated \nBank Systems or ABS for short. \n We've already set up an account for you.\n You can do a few things.\n\n Deposit your Euros :: Nod your head \n\n Withdraw Euros :: Tilt your head to the right, \ntype the ammount of euros you want\n and then tilt your head to the left.\n You have " + euros + " euros in your account" ;


            // check for head gestures
            //if (mainCamera.) { }
            //OVRDisplay.EyeRenderDesc
            //OVRInput.GetDown();
            //OVRInputControl.AddInputHandler();
            //OVRPose.identity.orientation;
            // fuck, to the internet
            // OVRSceneSampleController.



        }

    }
}
