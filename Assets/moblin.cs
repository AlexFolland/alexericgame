using UnityEngine;
using System.Collections;

public class moblin : MonoBehaviour {
    GameObject player;
    public float movementSpeed = 3f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moblinMovementVector = (player.transform.position - transform.position).normalized*movementSpeed*Time.deltaTime;
        transform.Translate(moblinMovementVector);
	}
}
