using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour {

    public float move_speed;
    public bool move_left;

    Rigidbody2D rB2D;

    // Use this for initialization
    void Start () {
        rB2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (move_left)
        {
            rB2D.velocity = new Vector2(-move_speed, rB2D.velocity.y);
        }

        }
}
