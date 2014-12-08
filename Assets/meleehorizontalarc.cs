using UnityEngine;
using System.Collections;

public class meleehorizontalarc : MonoBehaviour {

    GameObject sword;

	// Use this for initialization
	void Start () {
        sword = GameObject.FindGameObjectWithTag("Sword");
	}
	
	void PerformAction() {
        sword.GetComponent<sword>().MeleeHorizontalArc();
	}
}
