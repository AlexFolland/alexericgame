using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {
    private Animator animator;
    Component[] trailRenderers;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        trailRenderers = GetComponentsInChildren<TrailRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("Fire1"))
        {
            //to do:
            //
            //  -make animator inform me when it's done animating so I
            //  can disable the trail at that point
            //  -make the guy slash the full way every click
            //  -make this function more efficient (only enable trail on animation start)
            ////////////////////////////////////////////////////////////////////

            // play animation
            animator.SetBool("melee horizontal arc",true);

            // enable trail
            foreach (Component trailNode in trailRenderers)
            {
                trailNode.GetComponent<TrailRenderer>().enabled = true;
            }
        }else{
            //idle
            animator.SetBool("melee horizontal arc",false);

            // disable trail
            foreach (Component trailNode in trailRenderers)
            {
                trailNode.GetComponent<TrailRenderer>().enabled = false;
            }
        }
        //animator.Update(Time.deltaTime);
	}
}
