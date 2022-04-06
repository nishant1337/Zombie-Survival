
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{

    public void restartButton(){
//SceneManager.LoadScene("GameScene");
        HealthScript.healthValue=10000;
        LevelScript.levelValue=1;
        ScoreScript.scoreValue=0;
        SceneManager.LoadScene("GameScene");

    }

        public void closeButtonFromRestart(){
        Application.Quit();
        Debug.Log("closed");


    }
}
