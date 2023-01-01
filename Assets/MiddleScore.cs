using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScore : MonoBehaviour
{
    public LogicScript Logic;
    public BirdScript Bird;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.layer == 3 && Bird.BirdAlive)
        {
            Logic.AddScore(1);
        }
    }
}
