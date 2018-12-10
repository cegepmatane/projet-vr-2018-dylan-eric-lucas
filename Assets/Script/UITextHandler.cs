using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextHandler : MonoBehaviour {

    GameObject UIScore;
    Text UITextComponent;

    // Use this for initialization
    void Start () {
        this.UIScore = GameObject.Find("UIScore");
        this.UITextComponent = UIScore.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        this.UITextComponent.text = "Score : " + Score.getInstance().ScorePoints;
    }

}
