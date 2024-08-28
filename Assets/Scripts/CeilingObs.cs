using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CeilingObs : Obstacle
{
    public bool isHitted = false;
    void Update(){
        if(transform.position.x > -10f){
            if(!isHitted){
                transform.Translate(-6f * Time.deltaTime, 0f, 0f);
            }
            else{
                transform.Translate(-6f * Time.deltaTime, -9.8f * Time.deltaTime, 0f);
            }
        }
        else {
            Destroy(gameObject);
        }
    }
    public new void OnTriggerEnter2D(Collider2D other){
        base.OnTriggerEnter2D(other);
        if(other.gameObject.CompareTag("Bullet")){
            isHitted = true;
        }
        else if(other.gameObject.CompareTag("Ground")){
            isHitted = false;

        }
    }

}
