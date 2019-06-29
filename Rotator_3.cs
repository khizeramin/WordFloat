using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_3 : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 0, 0) * 0.03f);

        if (Input.GetMouseButtonDown(0))
        {
            // Entering Scene 2.
            rb.bodyType = RigidbodyType2D.Dynamic;

        }
    }
}

