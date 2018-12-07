using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject Player;
    float Timer;
    public float SpawnDelay = 2;
    int Wave;

	// Use this for initialization
	void Start ()
    {
        this.Player = GameObject.FindGameObjectWithTag("Player");
        this.Wave = 1;

        StartCoroutine(SpawnRoutine());
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*this.Timer += Time.deltaTime;

        if (this.SecondsTimer != (int)this.Timer % 60)
        {
            this.SecondsTimer = (int)this.Timer % 60;

            float randomNumber = Random.Range(0.0f, 1.0f);
            randomNumber += Mathf.Ceil(randomNumber * this.SecondsTimer / 100);
            for (int i = 0; i <= (int)randomNumber; i++)
            {
                this.SpawnNextEnemy();
            }
        }*/

	}

    IEnumerator SpawnRoutine()
    {
        while(true)
        {
            this.SpawnNextEnemy();

            yield return new WaitForSeconds(SpawnDelay);
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
    }

    Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-30.0f, 30.0f), 0.0f, Random.Range(-30.0f, 30.0f));
    }
}
