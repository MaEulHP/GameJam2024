using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CeilingObs : Obstacle
{
    public bool isHitted = false;
    public Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if(transform.position.x > -10f){
            if(!isHitted){
                transform.Translate(-5f * Time.deltaTime, 0f, 0f);
            }
            else{
                transform.Translate(-5f * Time.deltaTime, 0f, 0f);
                if(transform.position.y > -3.2f){
                    rb.gravityScale = 5f; 
                }
                else {
                    rb.gravityScale = 0f;
                    rb.velocity = new Vector2(0, 0);
                }
            }
        }
        else {
            Destroy(gameObject);
        }
    }
    public new void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            GameManager.instance.lastTime -= 2;
            Destroy(gameObject);
        }
        if(other.gameObject.CompareTag("Tracer")){
            GameManager.instance.lastTime += 1;
            Destroy(gameObject);
        }
        
    }

}
