using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Changescene : MonoBehaviour {

    // Use this for initialization
    public void Change(int cscene)
    {
        SceneManager.LoadScene(cscene);
    }

}
