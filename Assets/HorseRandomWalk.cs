using UnityEngine;
using System.Collections;

public class HorseRandomWalk : MonoBehaviour {

   
    public float n;
    public int randomDirection;


    // Use this for initialization
    void Start () {
        int row = 100;
        int col = 100;
        int[,] matrix;
        matrix = new int[row, col];

        

        Random randomMover = new Random();
        
        




	}

    // Update is called once per frame
    void Update() {


        
    //maybe just declare n in global scope?

        //Mesh meshy = gameObject.GetComponentInChildren<Mesh>();
        n = 10f;
        for (int i = 0; i < n; i++) {

            //Random randomHorse = new Random();
            Vector3 decidingVector = new Vector3(Mathf.Round(Random.Range(0, 5)), 0, 0);
            if (decidingVector.x == 1) {
                //right
                gameObject.transform.Translate(Vector3.right/10);
            }
            if (decidingVector.x == 2) {
                gameObject.transform.Translate(Vector3.left/10);
                //left

            }
            if (decidingVector.x == 3) {
                //forward
                gameObject.transform.Translate(Vector3.forward/10);
            }
            if (decidingVector.x == 4) {
                // down
                gameObject.transform.Translate(Vector3.back/10);
            }
            
        }



	
	}
}
