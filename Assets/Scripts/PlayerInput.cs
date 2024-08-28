using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public string jumpBtnName = "Jump";
    public string fireBtnName = "Fire1";
    public string slideBtnName = "Sliding";

    public bool fire { get; private set; }
    public bool jump { get; private set; }
    public bool slide { get; private set; }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance != null && GameManager.instance.isGameover) {
            fire = false;
            jump = false;
            slide = false;
            return;
        }
        fire = Input.GetKeyDown(KeyCode.Mouse0);
        jump = Input.GetKeyDown(KeyCode.Space);
        slide = Input.GetButton(slideBtnName);
        Debug.Log(slide); 
    }
}
