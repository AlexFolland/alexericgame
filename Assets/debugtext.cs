using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class debugtext : MonoBehaviour {
    
    Text txt;
    Event e;
    
    // Use this for initialization
    void Start () {
        txt = gameObject.GetComponent<Text>(); 
    }
    
    // Update is called once per frame
    void Update () {
        //if (e.keyCode.ToString() != "None") txt.text = "last e.keyCode was \"" + e.keyCode.ToString() + "\"";
        //if (e.isMouse.ToString() != "False") txt.text = txt.text + "\ne.isMouse = " + e.isMouse.ToString();
    }

    void OnGUI() {
        e = Event.current;
    }
}
