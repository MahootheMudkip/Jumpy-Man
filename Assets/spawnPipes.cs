using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class spawnPipes : MonoBehaviour
{
    public GameObject pipe;
    private float spawnCount = 0;
    public float spawnIntervalMS;
    private System.Random random = new System.Random();
    


    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCount < spawnIntervalMS)
        {
            spawnCount += Time.deltaTime;
        } else
        {
            spawnPipe();
            spawnCount = 0;
        }
    }

    void spawnPipe()
    {
        Vector3 pipePos = transform.position + Vector3.up * random.Next(-30, 30) / 100;
        Instantiate(pipe, pipePos, transform.rotation);
    }
}
