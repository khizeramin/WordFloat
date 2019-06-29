using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float X_Axis;
    private float Y_Axis;
    private float Z_Axis;
    private float flip;

    private Rigidbody2D rb;
    void Start()
    {
        X_Axis = 0.0F;
        Y_Axis = 0.0f;
        Z_Axis = 0.0f;
        flip = 0.1f;
         
        rb = GetComponent<Rigidbody2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 0, 0) * flip);
        if (Input.GetMouseButtonDown(0))
        {
            // Entering Scene 2.
            rb.bodyType = RigidbodyType2D.Dynamic;
         
        }
        //if (Time.time * 1000 < 5000)
        //{
        //    rb.bodyType = RigidbodyType2D.Static;
        //}
        //else
        //    rb.bodyType = RigidbodyType2D.Dynamic;
    }

}
