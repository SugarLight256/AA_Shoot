using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x >= 200 || transform.position.x <= -200 ||
       transform.position.y >= 200 || transform.position.y <= -200)
        {
            Destroy(transform.gameObject);
        }



	}

    private void Splash()
    {

    }

    void OnTriggerEnter2D()
    {
        Splash();
    }

}
