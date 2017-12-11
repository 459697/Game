using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour {

    public int starting_health = 5;
    public int current_health;

    // Use this for initialization
    void Start () {
        //Sets health when started up
        current_health = starting_health;
	}
	
	// Update is called once per frame
	void Update () {
		if (current_health <= 0)
            Destroy (gameObject);
    }

    public void hurt()
    {
        current_health--;
    }
}
