using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_control : MonoBehaviour {

    Rigidbody2D rB2D;

    public float speed;

	// Use this for initialization
	void Start () {
        rB2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
        rB2D.velocity = new Vector2(speed, rB2D.velocity.y);
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "ground")
        {
            Destroy (gameObject);
        }

        if (col.tag == "enemy")
        {
            col.gameObject.GetComponent<enemy_health>().hurt();
            Destroy(gameObject);
        }

    }
}
