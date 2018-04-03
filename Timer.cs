using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {
    //Image fillImg; //fill up chronometer behind count
    Text temp;
    float t=0;
    private float timeText;
    bool playing;
    int counter=0;
    int stop=0;
    Text tempoinit;    
    public int cenario;


    void Awake() //Awake runs before start
    {
        tempoinit = GameObject.Find("Countdown").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        if (playing == true) {

            t += Time.deltaTime*1;
            tempoinit.text = t.ToString("0");

            if (t > 60f || stop==1) 
            {
                ScoreManager.tempo = tempoinit.text;
                Debug.Log("tempo: " + ScoreManager.tempo);
                playing = false;
                SceneManager.LoadScene(1);

            }
        }  
    }


    public void ClickPlay()
    {

        playing = true;
    }

    public void ClickStop()
    {

        counter++;
        if (counter%2 == 0)
        {
            stop = 1;
        }
        else
        {
            stop = 0;
        }

    }
}
