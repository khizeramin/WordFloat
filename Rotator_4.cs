using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_4 : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(30, 0, 0) * 0.009f);


        if (Input.GetMouseButtonDown(0))
        {
            // Entering Scene 2.
            rb.bodyType = RigidbodyType2D.Dynamic;

        }

    }

    
    
}

