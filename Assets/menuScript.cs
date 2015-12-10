using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;


	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}


    public void ExitPress() {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        Debug.Log("You pressed exit");

        }

    public void NoPress() {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        
    }

    public void StartLoom() {
        Application.LoadLevel(0);
    }
    public void ExitLoom() {
        Application.Quit();

    }



	
	// Update is called once per frame
	void Update () {
	
	}
}
