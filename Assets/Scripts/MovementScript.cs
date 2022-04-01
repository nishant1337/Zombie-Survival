using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector3.back  * Time.deltaTime*( (LevelScript.levelValue)/4 + 0.3f));
     //transform.Translate(Vector3.back  * Time.deltaTime*0.3f);
    }
}
