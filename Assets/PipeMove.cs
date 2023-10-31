using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed;
    private double deadzone = -1.077088;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("deleted pipe");
        }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
