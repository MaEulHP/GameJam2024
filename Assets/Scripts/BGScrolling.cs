using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -18.2f){
            transform.Translate(-6f * Time.deltaTime, 0f, 0f);
        }
        else {
            transform.position = new Vector3(18.1f, 0f, 0f);
        }
    }
}
