using UnityEngine;
using System.Collections;

public class LMB : MonoBehaviour {

    GameObject action;

    // Use this for initialization
	void Start () {
        action = GameObject.Find("Action");
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            action.SendMessage ("PerformAction");
        }
	}
}
