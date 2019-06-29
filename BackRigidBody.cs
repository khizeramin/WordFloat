﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRigidBody : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {
            // Entering Scene 2.
            rb.bodyType = RigidbodyType2D.Dynamic;

        }
    }
}
