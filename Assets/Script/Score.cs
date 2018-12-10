using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    private static Score instance;

    public int ScorePoints;

    void Awake()
    {
        instance = this;
    }

    public static Score getInstance()
    {
        return instance;
    }

    // Use this for initialization
    void Start ()
    {
        this.ScorePoints = 0;
        StartCoroutine(ScoreUp());
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    IEnumerator ScoreUp()
    {
        while (true)
        {
            this.ScorePoints++;
            yield return new WaitForSeconds(1);
        }
    }
}
