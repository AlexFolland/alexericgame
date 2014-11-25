using UnityEngine;
using System.Collections;

public class moblin : MonoBehaviour {
    Transform playerWithCamera;
    public float movementSpeed = 1f;

	// Use this for initialization
	void Start () {
        playerWithCamera = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moblinMovementVector = (playerWithCamera.position - transform.position).normalized*movementSpeed*Time.deltaTime;
        transform.Translate(moblinMovementVector * movementSpeed);
	}
}
