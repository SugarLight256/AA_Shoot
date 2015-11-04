using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    private GameObject tp;
    private Rigidbody2D myRigid;

    public int maxHP;
    public int HP;

    public float accel;
    public float maxSpeed;
	// Use this for initialization
	void Start () {
        tp = GameObject.Find("TouchPointer");
        myRigid = GetComponent<Rigidbody2D>();
        HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, tp.transform.position) >= accel / 10)
        {
            //Move();
        }
        else
        {
            myRigid.velocity = Vector2.zero;
        }
	}

    private void Move()
    {
        Vector2 moveAngle;
        moveAngle = new Vector2(tp.transform.position.x - transform.position.x, tp.transform.position.y - transform.position.y).normalized;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, moveAngle);
        myRigid.velocity = accel * moveAngle;
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "E_bull")
        {
            HP--;
            Destroy(c.transform.gameObject);
        }
    }
}
