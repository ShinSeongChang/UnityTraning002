using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject[] treePrefab;

    private int random_Tree = 0;

    private float spawnMin = 0.5f;
    private float spawnMax = 3.0f;
    private float spawnRate = default;
    private float timeAfterspawn = default;


    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(spawnMin, spawnMax);
        random_Tree = Random.Range(0, 4);

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterspawn += Time.deltaTime;

        if(timeAfterspawn >= spawnRate)
        {
            GameObject.Instantiate(treePrefab[random_Tree], transform.position, transform.rotation);

        }

        spawnRate = Random.Range(spawnMin, spawnMax);
        random_Tree = Random.Range(0, 4);
    }
}
