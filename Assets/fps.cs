using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fps : MonoBehaviour {

    Text txt;
    int frameCount = 0;
    float dt = 0.0f;
    float framerate = 0.0f;
    float updateRate = 60.0f; // number of updates per sec.

	// Use this for initialization
	void Start () {
        txt = gameObject.GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update () {
        frameCount++;
        dt += Time.deltaTime;
        if (dt > 1.0f/updateRate)
        {
            framerate = frameCount / dt ;
            frameCount = 0;
            dt -= 1.0f/updateRate;
        }
        txt.text = GameObject.FindGameObjectWithTag("Sword").GetComponent<Animator>().GetCurrentAnimatorStateInfo(-1).IsName("melee horizontal arc").ToString() + " " + Mathf.Floor(framerate).ToString() + " fps";
	}
}
