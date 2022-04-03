using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class HealthScript : MonoBehaviour
{
    public TextMeshProUGUI health;

    public static int healthValue = 10000;
    // Start is called before the first frame update
    void Start()
    {
        health= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthValue<0){
            SceneManager.LoadScene("Restart");


        }
        health.text= "Health : "+ (healthValue/100);
        
    }
}
