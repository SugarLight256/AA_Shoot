using UnityEngine;
using System.Collections;

public class TP : MonoBehaviour {

    public Camera mc;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            transform.position = mc.ScreenToWorldPoint(Input.touches[0].position);
        }
	}
}
