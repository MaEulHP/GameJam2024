using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] ObstacleList;
    private List<GameObject> bag = new List<GameObject>();

    void Start()
    {
        RefillBag();
        InvokeRepeating("SpawnObs", 1f, 2f);
    }

    void RefillBag(){
        bag.Clear();
        foreach(GameObject prefab in ObstacleList){
            bag.Add(prefab);
        }
        ShuffleBag();
    }

    void ShuffleBag()
    {
        for (int i = 0; i < bag.Count; i++){
            GameObject tmp = bag[i];
            int randomInx = Random.Range(i, bag.Count);
            bag[i] = bag[randomInx];
            bag[randomInx] = tmp;
        }
    }

    public void SpawnObs()
    {
        if(bag.Count == 0){
            RefillBag();
        }

        GameObject obsToSpawn = bag[0];
        bag.RemoveAt(0);

        Instantiate(obsToSpawn, 
        new Vector3(transform.position.x, obsToSpawn.transform.position.y, 0), Quaternion.identity);
    }

}
