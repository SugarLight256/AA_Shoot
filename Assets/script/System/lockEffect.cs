using UnityEngine;
using System.Collections;

public class lockEffect : MonoBehaviour {

    private GameObject TP;
    private GameObject target;
    private Transform child1;
    private Transform child2;
	// Use this for initialization
	void Start () {
        child1 = transform.GetChild(0);
        child2 = transform.GetChild(1);
	}
	
	// Update is called once per frame
    void Update()
    {
        if (TP == null || target == null)
        {
            Destroy(transform.gameObject);
        }
        else
        {
            transform.position = target.transform.position;
            child1.Rotate(new Vector3(0, 0, -5));
            child2.Rotate(new Vector3(0, 0, -3));
        }
    }

    public void SetTP(GameObject lTP, GameObject enemy)
    {
        TP = lTP;
        target = enemy;
    }
}
