using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour {
    private Animator animator;
    //private TimedTrailRenderer trail;
    public Object trailNode;
    GameObject trail;

	// Use this for initialization
	void Start()
    {
        animator = GetComponent<Animator>();
        //trail = GetComponent<TimedTrailRenderer>();
    }
    
    // Update is called once per frame
	void Update()
    {
        //attack
        if(Input.GetButtonDown("Fire1"))
        {
            if(trail) Destroy(trail);

            // play animation
            animator.SetTrigger("melee horizontal arc");
        }
	}

    public void InstantiateTrail()
    {
        // enable trail
        trail = (GameObject)Instantiate(trailNode,transform.position,transform.rotation);
        
        // set trail as child
        trail.transform.SetParent(transform);
    }

    public void DestroyTrail()
    {
        // disable trail
        Destroy (trail);
    }
}
