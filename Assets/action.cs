using UnityEngine;
using System.Collections;

public class action : MonoBehaviour {

    public Object actionObject;
    public Sprite actionIcon;
    GameObject instantiatedActionObject;

	// Use this for initialization
	void Start () {
        instantiatedActionObject = (GameObject)Instantiate(actionObject,transform.position,transform.rotation);
	}
	
    void PerformAction()
    {
        instantiatedActionObject.SendMessage("PerformAction");
    }

	// Update is called once per frame
	//void Update () {}
}
