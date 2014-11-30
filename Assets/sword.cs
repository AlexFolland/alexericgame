using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {
    private Animator animator;
    Component[] trailRenderers;
    //Transform trailNode;
    //Object trail;

	// Use this for initialization
	void Start()
    {
        animator = GetComponent<Animator>();
        trailRenderers = GetComponentsInChildren<TrailRenderer>();
    }
    
    // Update is called once per frame
	void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //to do:
            //
            // -implement game
            // -ship it
            // -profit
            // -live the dream
            //
            ////////////////////////////////////////////////////////////////////

            // if animating
            if(animator.GetBool ("melee horizontal arc"))
            {
                //rewind to allow another animation to start
                animator.Play("melee horizontal arc", -1, 0f);
            }

            // play animation
            animator.SetBool("melee horizontal arc",true);

            // enable trail
            //trail = Instantiate (trailNode, new Vector3(0, 0, 0), Quaternion.identity);

            foreach(Component trailNode in trailRenderers)
            {
                trailNode.GetComponent<TrailRenderer>().enabled = true;
            }
        }
	}

    public void AnimationEnd()
    {
        // disable trail
        //Destroy (trail);

        foreach (Component trailNode in trailRenderers)
        {
            trailNode.GetComponent<TrailRenderer>().enabled = false;
        }
        
        //idle
        animator.SetBool("melee horizontal arc",false);
    }
}
