using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D pRigidbody;
    private Animator pAnimator;
    
    public bool jumpable = true;
    Vector3 mousePos;
    Camera cam;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        pRigidbody = GetComponent<Rigidbody2D>();
        pAnimator = GetComponent<Animator>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpable && playerInput.jump){
            Jump();
        }
        if(playerInput.fire){
            Shot();
        }
    }

    public void Jump(){
        pRigidbody.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        jumpable = false;
    }
    public void Shot(){
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cam.transform.position.z));
        Debug.Log(mousePos);
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            jumpable = true;
        }
    }

}
