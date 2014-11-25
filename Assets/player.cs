using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    Transform link;
    Transform playerWithCamera;
    public float movementSpeed = 8f;

	// Use this for initialization
	void Start () {
        link = transform.FindChild("Link");
        playerWithCamera = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        //movement
        Vector3 playerMovementVector = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized*movementSpeed*Time.deltaTime;
		playerWithCamera.Translate(playerMovementVector);

        //face the cursor
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        if(hit.collider.gameObject.tag == "Terrain"){
            Vector3 lookTarget = hit.point;
            lookTarget.y += link.transform.position.y; // character's vertical position; a little above ground
            link.transform.LookAt(lookTarget);
        }
        else if(hit.collider.gameObject.tag == "Floor")
        {
            Vector3 lookTarget = hit.point;
            lookTarget.y += link.transform.position.y; // character's vertical position; a little above ground
            link.transform.LookAt(lookTarget);
        }
	}
}
