using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject Player;
    int Score;
    public float SpawnDelay = 2;

	// Use this for initialization
	void Start ()
    {
        this.Player = GameObject.FindGameObjectWithTag("Player");
        this.Score = 0;

        StartCoroutine(SpawnRoutine());
        StartCoroutine(ScoreUp());
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            this.SpawnNextEnemy();
            yield return new WaitForSeconds(SpawnDelay);
        }
    }

    IEnumerator ScoreUp()
    {
        while (true)
        {
            this.Score++;
            yield return new WaitForSeconds(1);
        }
    }

    void SpawnNextEnemy()
    {
        GameObject newEnemy = Instantiate(Resources.Load("EnemyPrefab")) as GameObject;

        Vector3 newEnnemyPosition = getRandomPosition();
        while(Vector3.Distance(Player.transform.position, newEnnemyPosition) < 15.0f)
        {
            newEnnemyPosition = getRandomPosition();
        }
        newEnemy.transform.position = newEnnemyPosition;

        newEnemy.tag = "Zombie";
    }

    Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-30.0f, 30.0f), 0.0f, Random.Range(-30.0f, 30.0f));
    }
}
