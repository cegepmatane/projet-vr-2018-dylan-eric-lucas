using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Zombie")
        {
            // Add score
            Score score = Score.getInstance();
            score.addScore(5);
            //If the GameObject has the same tag as specified, output this message in the console
            Enemy script;
            script = collision.gameObject.GetComponent<Enemy>();
            script.Die();
            script.enabled = false;
            Destroy(script.gameObject, 3);
        }
    }
}
