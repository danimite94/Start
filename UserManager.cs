using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq; //use with collections


public class UserManager : MonoBehaviour {

    public InputField input;
    public Text input2;
    string userin;
    float userin2;
    Timer timer;
    float tempo;

    private void Update()
    {

        ShowTime();
        if (input == null) //to avoid initialization
            Debug.Log("NULL!!");
        else
            ScoreManager.SetSilentimes(input.text, ScoreManager.tempo.ToString());
    }

    // Use this for initialization
    public void Getuser(string entrada) //Awake runs before start
    {
        Debug.Log("U: " + entrada);
        input.text = "";

    }

    public void ShowTime() //Awake runs before start
    {
        //input2.text = "43"; // timer.Gettime().ToString("0");
        input2.text = ScoreManager.tempo.ToString();
        userin2 = float.Parse(input2.text);
        Debug.Log("T:" + userin2);

    }
    

}

