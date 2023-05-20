using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    float timer;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2) 
        {
            var rndmSpawn = Random.Range(0, enemyPrefabs.Length - 1);
            var Clone = Instantiate(enemyPrefabs[rndmSpawn], transform.position, Quaternion.identity);
            Destroy(Clone, 3f);
            timer = 0;
        }
    }
}
