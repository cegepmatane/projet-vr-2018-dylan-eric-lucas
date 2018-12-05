using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    float Timer;
    int SecondsTimer;

	// Use this for initialization
	void Start () {
        this.Timer = 0.0f;
        this.SecondsTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        this.Timer += Time.deltaTime;

        if (this.SecondsTimer != (int)this.Timer % 60)
        {
            this.SecondsTimer = (int)this.Timer % 60;
            this.SpawnNextEnemy();
        }

	}

    void SpawnNextEnemy()
    {
        //GameObject newEnemy = Instantiate(new Enemy().gameObject);
        //newEnemy.transform.position = new Vector3(0, -1 + transform.localScale.y / 2, 0);

        //GameObject newEnemy = GameObject.CreatePrimitive();
        // Besoin de regarder de la doc sur les prefab

    }
}
