using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


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
         //Debug.Log( "Zombie1" +GameObject.Find("zombie1(Clone)").transform.position);
         //Debug.Log( "Zombie2" +GameObject.Find("zombie2(Clone)").transform.position);
         //Debug.Log( "Zombie3" +GameObject.Find("zombie3(Clone)").transform.position);
         //Debug.Log( "GUN" +GameObject.Find("Double-barrel_gun").transform.position);

        
        if (GameObject.Find("zombie1(Clone)").transform.position.z <0){
            Destroy(GameObject.Find("zombie1(Clone)")); 
        } 
        if (GameObject.Find("zombie2(Clone)").transform.position.z <0){
            Destroy(GameObject.Find("zombie2(Clone)")); 
        } 
        if (GameObject.Find("zombie3(Clone)").transform.position.z <0){
            Destroy(GameObject.Find("zombie3(Clone)")); 
        } 

         float distance1=GameObject.Find("zombie1(Clone)").transform.position.z - GameObject.Find("Double-barrel_gun").transform.position.z;
         
         if ( distance1 <1  && distance1>0 ){
             Debug.Log("DAMAGE TAKEN");
             HealthScript.healthValue-=5;
         }



         float distance2=GameObject.Find("zombie2(Clone)").transform.position.z - GameObject.Find("Double-barrel_gun").transform.position.z;
         
         if ( distance2 <1  && distance2>0 ){
             Debug.Log("DAMAGE TAKEN");
             HealthScript.healthValue-=5;
         }

         float distance3=GameObject.Find("zombie3(Clone)").transform.position.z - GameObject.Find("Double-barrel_gun").transform.position.z;
         
         if ( distance3 <1  && distance3>0 ){
             Debug.Log("DAMAGE TAKEN");
             HealthScript.healthValue-=5;
         }

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
