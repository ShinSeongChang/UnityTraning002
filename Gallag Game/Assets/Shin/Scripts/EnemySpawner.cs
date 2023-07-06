using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject[] enemyPrefab;

    public float spawnMin = 30.0f;
    public float spawnMax = 60.0f;
    private float spawnRate = default;

    private Transform target = default;
    private int random_Target = 0;

    private int randomSpawn = default;
    private float timeAfterspawn = default;



    // Start is called before the first frame update
    void Start()
    {
        timeAfterspawn = 0f;

        randomSpawn = Random.Range(0, 7);
        random_Target = Random.Range(0, 10);
        spawnRate = Random.Range(spawnMin, spawnMax);

        target = FindObjectOfType<MoveCar>().transform;

    }

    // Update is called once per frame
    void Update()
    {

        timeAfterspawn += Time.deltaTime;

        if(timeAfterspawn >= spawnRate)
        {
            timeAfterspawn = 0f;
            GameObject enemy = Instantiate(enemyPrefab[randomSpawn], transform.position, transform.rotation);

            if (random_Target < 5)
            {
                enemy.transform.LookAt(target);
            }

            spawnRate = Random.Range(spawnMin, spawnMax);
            randomSpawn = Random.Range(0, 7);
            random_Target = Random.Range(0, 10);
        }
    }
}
