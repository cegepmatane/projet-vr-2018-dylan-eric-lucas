using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;

	// Use this for initialization
	void Start () {
        this.Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) >= this.MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.transform.position) <= this.MaxDist)
            {
                // Debug.Log("close to the player");
            }
        }
	}

    public void Die()
    {

    }

}
