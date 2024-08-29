using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -10f){
            transform.Translate(-5f * Time.deltaTime, 0f, 0f);
        }
        else {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            GameManager.instance.lastTime -= 2;
        }
        if(other.gameObject.CompareTag("Tracer")){
            GameManager.instance.lastTime += 1;
        }
        Destroy(gameObject);
    }
    
}
