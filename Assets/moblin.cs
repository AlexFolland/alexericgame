using UnityEngine;
using System.Collections;

public class moblin : MonoBehaviour {
    Transform player;
    public float movementSpeed = 2f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform.FindChild("Link").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moblinMovementVector = (player.position - transform.position).normalized*movementSpeed*Time.deltaTime;
        transform.Translate(moblinMovementVector);
	}
}
