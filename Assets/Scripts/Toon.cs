using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Toon : MonoBehaviour
{
    public Image[] imageSet;
    public Button nextBtn;
    int i = 0;

    void Start()
    {
        nextBtn.onClick.AddListener(nextCut);
    }
    void nextCut(){
        i++;
        if(i < 4){
            imageSet[i].gameObject.SetActive(true);
        }
        
        else{
            SceneManager.LoadScene("MainPlay");
        }
    }
}
