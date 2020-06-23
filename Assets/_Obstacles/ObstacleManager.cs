using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] Obstacles;

    public int NextSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        NextSpawn -= 1;
        int random = Random.Range(0, 4);

        Vector3 spawnPos = new Vector3(Random.Range(-2f, 2f), 0f, 0f);

        if (NextSpawn <= 0)
        {
            Instantiate(Obstacles[random], spawnPos, Quaternion.identity);
            NextSpawn = 1;
        }
    }
}
