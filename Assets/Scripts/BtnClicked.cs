using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnClicked : MonoBehaviour
{
    public Button StartBtn;
    public Button QuitBtn;
    // Start is called before the first frame update
    void Start()
    {
        if(StartBtn != null && QuitBtn != null){
            StartBtn.onClick.AddListener(gameStart);
            QuitBtn.onClick.AddListener(gameExit);
        }
    }
    void gameStart(){
        SceneManager.LoadScene("Cartoon");
    }
    void gameExit(){
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
}
