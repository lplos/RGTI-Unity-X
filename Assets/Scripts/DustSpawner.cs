using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustSpawner : MonoBehaviour
{
    public int DustCount = 0;
    public GameObject dustPrefab;
    public void Awake(){
        DustCount = Random.Range(1, 10);
        for(int i = 0; i < DustCount; i++){
        int spawnPointX = Random.Range(-10, 10);
        int spawnPointY = 0;
        int spawnPointZ = Random.Range(-10, 10);

        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(dustPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
