using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Player p;
    float normalValue;
    float distance;
    // Update is called once per frame
    void Update()
    {
        normalValue = Mathf.InverseLerp(0f, 30f, GameManager.instance.lastTime);
        distance = Mathf.Lerp(0f, 10f, normalValue) + 3f;
        transform.position = new Vector3(p.transform.position.x-distance, transform.position.y, 0);
    }
}

