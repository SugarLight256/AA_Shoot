using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour {

    public GameObject target;
    private Rigidbody2D myRigid;

    public float speed;
    public float rot;
    private Vector3 deltaPos;

    private float deltaAngle;
    private float targetAngle;
    private float myAngle;

	// Use this for initialization
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 200 || transform.position.x <= -200 ||
        transform.position.y >= 200 || transform.position.y <= -200)
        {
            Destroy(transform.gameObject);
        }
        if (target == null)
        {
            myRigid.velocity = speed * transform.up;
            return;
        }
        deltaPos = target.transform.position - transform.position;
        targetAngle = Mathf.Atan2(deltaPos.y, deltaPos.x) * Mathf.Rad2Deg;
        myAngle = Mathf.Atan2(myRigid.velocity.y, myRigid.velocity.x) * Mathf.Rad2Deg;
        deltaAngle = Mathf.DeltaAngle(myAngle, targetAngle);
        if (Mathf.Abs(deltaAngle) > rot)
        {
            if (deltaAngle > 0)
            {
                transform.Rotate(new Vector3(0, 0, rot));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -rot));
            }
        }
        myRigid.velocity = speed * transform.up;
    }

    public void SetTarget(GameObject t)
    {
        target = t;
    }
}
