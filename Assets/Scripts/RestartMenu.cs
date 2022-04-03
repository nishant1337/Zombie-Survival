
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{

    public void restartButton(){
//SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene("Main Menu");

    }

        public void closeButtonFromRestart(){
        Application.Quit();
        Debug.Log("closed");


    }
}
