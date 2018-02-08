using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Better_Jump : MonoBehaviour {

    public float fallMultiplier = 5f;
    public float lowJumpmultiplier = 5f;

    Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update(){
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }

}