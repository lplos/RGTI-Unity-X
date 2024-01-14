using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustSpawner : MonoBehaviour
{
    public int DustCount = 0;
    public GameObject dustPrefab;
    public void Awake(){
        DustCount = Random.Range(3, 20);
        for(int i = 0; i < DustCount; i++){
        int spawnPointX = Random.Range(-20, 20);
        int spawnPointY = 0;
        int spawnPointZ = Random.Range(-28, 20);
            if (spawnPointZ >= -19 && spawnPointZ < -15){
    // Move to the next range (15, 20)
    spawnPointZ = Random.Range(-14, 20);
        }       
        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(dustPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
