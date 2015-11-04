using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {

    private Rigidbody2D myRigid;
    private CircleCollider2D myCollider;
    private Vector2 pos;
    private GameObject target;
    public GameObject localPos;

    private float timer;
    public float cool;

    public GameObject bull;
    public float accel;
	// Use this for initialization
	void Start () {
        myRigid = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        pos = localPos.transform.position;
        if (Vector2.Distance(transform.position, pos) >= accel / 10)
        {
            move();
        }
        else
        {
            myRigid.velocity = Vector2.zero;
        }
        timer += Time.deltaTime;
        if (timer >= cool && target != null)
        {
            timer = 0;
            shot();
        }
        if (target && Vector2.Distance(transform.position, target.transform.position) >= myCollider.radius + myCollider.radius/10)
        {
            target = null;
        }
	}

    private void shot()
    {
        Vector2 shotAngle;
        shotAngle = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y).normalized;
        Instantiate(bull, transform.position, Quaternion.FromToRotation(Vector3.up, shotAngle));
    }

    private void move()
    {
        Vector2 moveAngle;
        moveAngle = new Vector2(pos.x - transform.position.x, pos.y - transform.position.y).normalized;
        if (target)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y).normalized);
        }
        else
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, moveAngle);
            //retarget();
        }
        accel = Vector2.Distance(transform.position, pos) * 1.1f;
        myRigid.velocity = accel * moveAngle;
    }

    void OnTriggerStay2D(Collider2D c)
    {
        if (target != null)
        {
            if (Vector2.Distance(c.transform.position, transform.position) <= Vector2.Distance(target.transform.position, transform.position))
            {
                target = c.gameObject;
            }
        }
        else
        {
            target = c.gameObject;
        }
    }
}
