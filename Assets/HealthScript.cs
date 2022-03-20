using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HealthScript : MonoBehaviour
{
    public TextMeshProUGUI health;

    public static int healthValue = 100;
    // Start is called before the first frame update
    void Start()
    {
        health= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        health.text= "Health : "+ healthValue;
        
    }
}
