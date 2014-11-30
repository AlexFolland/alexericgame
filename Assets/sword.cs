using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {
    private Animator animator;
    //Component[] trailRenderers;
    public Object trailNode;
    GameObject trail;

	// Use this for initialization
	void Start()
    {
        animator = GetComponent<Animator>();
        //trailRenderers = GetComponentsInChildren<TrailRenderer>();
    }
    
    // Update is called once per frame
	void Update()
    {
        //attack
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
                // disable trail
                Destroy (trail);

                //rewind to allow another animation to start
                animator.Play("melee horizontal arc", -1, 0f);
            }

            // play animation
            animator.SetBool("melee horizontal arc",true);
            transform.renderer.enabled = false;

            // enable trail
            trail = (GameObject)Instantiate(trailNode, transform.position, transform.rotation);

            // set trail as child
            trail.transform.SetParent(transform);
        }
	}

    public void AnimationEnd()
    {
        // disable trail
        Destroy (trail);

        // idle
        animator.SetBool("melee horizontal arc",false);
        transform.renderer.enabled = true;
    }
}
