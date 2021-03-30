using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D Body;
    public float speed;
    public Transform transform;
    
    void start()
    {
        // use this function to initialize
        // anything
    }
    
    // Update is called once per frame
    void Update()
    {
        Body.velocity = (new Vector2(Input.GetAxisRaw("Horizontal")*speed, Input.GetAxisRaw("Vertical")*speed));
    }

}
