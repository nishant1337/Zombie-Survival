using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LevelScript : MonoBehaviour
{
    public TextMeshProUGUI level;

    public static int levelValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        level= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        level.text= "level : "+ levelValue;
        
    }
}
