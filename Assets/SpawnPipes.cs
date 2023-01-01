using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnInterval = 2;
    private float Timer = 0;
    public float HeightOffset = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < SpawnInterval)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            Timer = 0;
        }
    }
    // Spawn a new pipe
    void SpawnPipe()
    {
        float LowestPoint = transform.position.y - HeightOffset;
        float HighestPoint = transform.position.y + HeightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0), transform.rotation);
    }
}
