using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D pRigidbody;
    private Animator pAnimator;
    private Collider2D BoxCollider2D;
    
    public bool jumpable = true;
    Vector3 mousePos;
    Vector2 mPos2D;
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
        if (playerInput.slide) {
            pAnimator.SetBool("isSlide", true);
            StartSliding();

        }
        else if (playerInput.slide == false){
            pAnimator.SetBool("isSlide", false);
            StopSliding();
        }
    }
    public void Jump(){
        SoundManager.instance.Playjump(0);
        pRigidbody.AddForce(new Vector2(0f, 10.5f), ForceMode2D.Impulse);
        jumpable = false;
        pAnimator.SetBool("Jump", true);
    }
    public void Shot(){
        SoundManager.instance.PlayshootFire(0);
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cam.transform.position.z));
        Vector2 mPos2D = new Vector2(mousePos.x, mousePos.y);
        pAnimator.SetTrigger("Shoot");
        RaycastHit2D hit = Physics2D.Raycast(mPos2D, Vector2.zero);
        if(hit.collider != null){
            GameObject hitObj = hit.collider.gameObject;
            if(hitObj.CompareTag("Obstacle")){
                Destroy(hitObj);
            }
            else if (hitObj.CompareTag("CeilingObs")){
                CeilingObs cObs = hitObj.GetComponent<CeilingObs>();
                if(cObs != null){
                    cObs.isHitted = true;
                }
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            jumpable = true;
            pAnimator.SetBool("Jump", false);
        }
    }
    void StartSliding()
    {
        var collider = GetComponent<BoxCollider2D>();
        collider.size = new Vector2(1.5f, 0.5f);
        collider.offset = new Vector2(0f, -0.25f);
    }

    void StopSliding()
    {
        var collider = GetComponent<BoxCollider2D>();
        collider.size = new Vector2(0.5f, 1.5f);
        collider.offset = new Vector2(0f, 0f);
    }


}
