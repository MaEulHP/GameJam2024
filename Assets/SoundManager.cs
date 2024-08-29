using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance{
        get
        {
            if(m_instance == null){
                m_instance = FindObjectOfType<SoundManager>();
            }

            return m_instance;
        }
    }
    private static SoundManager m_instance;
    void Awake(){
        if(instance != this){
            Destroy(gameObject);
        }
    }

    public AudioSource Bgm, shoot, jumpSound;
    public AudioClip[] bClip, sClip, jClip;

    public void PlayBgm(int inx){
        Bgm.clip = bClip[inx];
        Bgm.Play();
    }
    public void PlayshootFire(int inx){
        shoot.clip = sClip[inx];
        shoot.Play();
    }
    public void Playjump(int inx){
        jumpSound.clip = jClip[inx];
        jumpSound.Play();
    }
}
