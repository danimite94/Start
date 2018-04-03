using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {

    public Text rank1;
    public Text rank2;
    public Text rank3;
    public Text rank4;
    public Text rank5;
    public Text rank6;
    public Text rank7;
    public Text rank8;
    public Text rank9;
    public Text rank10;

    string[] Users;
	// Use this for initialization
	void Start () {
        Users = ScoreManager.Getusers();
	}
	
	// Update is called once per frame
	void Update () {
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];
        rank1.text = Users[1];

    }
}
