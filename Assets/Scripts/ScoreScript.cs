using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI score;

    public static int scoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        score= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        score.text= "Score : "+ scoreValue;
        
        if ( scoreValue<=10) {
                LevelScript.levelValue= 1;

        }
        else if ( scoreValue>10  & scoreValue<=25){
            LevelScript.levelValue= 2;

        }
        else if ( scoreValue>25 ){
            LevelScript.levelValue= 3;
        }
    }
}
