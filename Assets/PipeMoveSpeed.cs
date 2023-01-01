using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveSpeed : MonoBehaviour
{
    public float MovementSpeed = 5;
    public float DeadZone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * MovementSpeed) * Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
