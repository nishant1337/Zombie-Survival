using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    // Start is called before the first frame update

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
       animator= GetComponent<Animator>();
       
    }
    // Update is called once per frame
     void Update()
    {    
new WaitForSeconds(10);
        //animator.Play("death_01");
    }
    public void Shoot(){
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
          if(hit.transform.name=="zombie1(Clone)" || hit.transform.name=="zombie2(Clone)"  || hit.transform.name=="zombie3(Clone)" || hit.transform.name=="zombie4(Clone)" || hit.transform.name=="zombie5(Clone)"  ){
                ScoreScript.scoreValue+=1;
                Destroy(hit.transform.gameObject);
                Instantiate(smoke,hit.point,Quaternion.LookRotation(hit.normal));
            }
        }
        
    }
}
