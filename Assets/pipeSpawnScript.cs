using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 5;
    public float heightBaseValue = 1;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else 
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset + heightBaseValue;
        float highestPoint = transform.position.y + heightOffset + heightBaseValue;
        float randomizedY = Random.Range(lowestPoint, highestPoint);
        Instantiate(pipe, new Vector3(transform.position.x, randomizedY, 0), transform.rotation);
    }
}
