using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject spawnArea;//3d object with sphere 3d collider
    public GameObject player;
    public GameObject[] enemyPrefabs;
    public GameObject enemyContainer;
    public float spawnSafeDistance;//how far from player at spawn
    public float maxSpawnDistance;
    public float spawnTimeEvery;
    public int maxEnemies;

    float time = 0;

    ///private double terrainWidth;
    //private double terrainHeight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnTimeEvery)
        {
            time = 0;
            if (GameObject.FindGameObjectsWithTag("enemy").Length < maxEnemies)
                Spawn();
        }
    }

    public void Spawn()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        int guard = 0;

        do
        {
            pos.x = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            pos.y = Random.Range(0, maxSpawnDistance);
            pos.z = Random.Range(-maxSpawnDistance, maxSpawnDistance);
            pos += player.transform.position;
            if (guard++ > 1000)
                break;
        } while ((pos - player.transform.position).magnitude < spawnSafeDistance &&
                (pos - player.transform.position).magnitude > maxSpawnDistance);

        GameObject enemy = Instantiate(enemyPrefabs[0], enemyContainer.transform);
        enemy.transform.position = pos;
    }
}
