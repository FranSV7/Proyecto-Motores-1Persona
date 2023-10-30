using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject enemy;
    public Vector3[] positionSpawn;
    public float time;
    public float repeat;
    public Transform spawnEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", time, repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        int random = Random.Range(0, positionSpawn.Length);
        Instantiate(enemy, spawnEnemy.position, spawnEnemy.rotation);

    }
}
