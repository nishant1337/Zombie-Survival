using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLeftZombie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector3.back  * Time.deltaTime*( (LevelScript.levelValue)/4 + 0.2f));
     transform.Translate(Vector3.left  * Time.deltaTime*( (LevelScript.levelValue)/4 + 0.2f));
    }
}

