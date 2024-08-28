using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartUICtrl : MonoBehaviour
{
    public RectTransform folder;
    public Vector2 startPosition; 
    public Vector2 endPosition; 
    void Start(){
        startPosition = new Vector2(0f, -450f);
        endPosition = new Vector2(0f, 0f);
        StartCoroutine(MoveUI());
    }
    IEnumerator MoveUI(){
        float elapsedTime = 0f;

        while(elapsedTime < 2f){
            folder.anchoredPosition = Vector2.Lerp(startPosition, endPosition, elapsedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        folder.anchoredPosition = endPosition;
    }
}
