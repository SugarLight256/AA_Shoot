using UnityEngine;
using System.Collections;

public class P_bull : MonoBehaviour {

    private Rigidbody2D myRigid;

    public float speed;

	// Use this for initialization
	void Start () {
        myRigid = GetComponent<Rigidbody2D>();
        myRigid.AddForce(speed * transform.up);
	}
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x >= 200 || transform.position.x <= -200 ||
           transform.position.y >= 200 || transform.position.y <= -200)
        {
            Destroy(transform.gameObject);
        }

	}
}
