using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text LastTxt;

    // Update is called once per frame
    void Update()
    {
        LastTxt.text = "Last time : " + GameManager.instance.lastTime.ToString();
    }
}
