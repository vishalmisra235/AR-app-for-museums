using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscene : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("ar2");
    }
}
