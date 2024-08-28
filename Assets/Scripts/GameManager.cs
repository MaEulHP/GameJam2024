using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{
        get
        {
            if(m_instance == null){
                m_instance = FindObjectOfType<GameManager>();
            }

            return m_instance;
        }
    }
    private static GameManager m_instance;

    public float score = 0;
    public float lastTime = 30; 
    public bool isGameover {get; private set;}

    private void Awake() 
    {
        if(instance != this){
            Destroy(gameObject);
        }
    }
    public void Update()
    {
        if(lastTime > 0f){
            score += Time.deltaTime;
            lastTime -= Time.deltaTime;
        }
        else {
            isGameover = true;
        }
    }
}


