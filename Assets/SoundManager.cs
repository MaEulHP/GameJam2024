using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }
        return;
    }

    public AudioSource Bgm, shoot, jump;
    private AudioClip bClip, sClip, jClip;

    public void PlayBgm(){
        Bgm.clip = bClip;
        Bgm.Play();
    }
    public void PlayshootFire(){
        shoot.clip = sClip;
        shoot.Play();
    }
    public void Playjump(){
        jump.clip = jClip;
        jump.Play();
    }
}
