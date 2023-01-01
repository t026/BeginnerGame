using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript Logic;
    public bool BirdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space) && BirdAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        Logic.GameOver();
        BirdAlive = false;
    }
}
