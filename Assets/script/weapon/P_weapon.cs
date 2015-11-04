using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P_weapon : MonoBehaviour {

    private GameObject tp;
    public GameObject msg;
    public GameObject can;
    public GameObject mis;
    public GameObject las;
    public GameObject lockTp;

    public List<GameObject> miss;
    public List<GameObject> enemys;

    public int knd;
    public float cool;
    public float time;

	// Use this for initialization
	void Start () {
        tp = GameObject.Find("TouchPointer");
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.FromToRotation(Vector3.up, new Vector2(tp.transform.position.x - transform.position.x, tp.transform.position.y - transform.position.y).normalized);
        switch (knd)
        {
            case 0:
                Msg();
                break;
            case 1:
                Can();
                break;
            case 2:
                Mis();
                break;
            case 3:
                Las();
                break;
        }
        time += Time.deltaTime;
	}

    private void Msg()
    {
        if (time >= cool)
        {
            Instantiate(msg, transform.position, transform.rotation);
            time = 0;
        }
    }

    private void Can()
    {
        if (time >= cool)
        {
            Instantiate(can, transform.position, transform.rotation);
            time = 0;
        }
    }

    private void Mis()
    {
        if (time >= cool)
        {
            if (Input.touchCount>=1 && Input.touches[0].phase == TouchPhase.Began)
            {
                Instantiate(lockTp, transform.position, transform.rotation);
            }
        }
    }

    private void Las()
    {
        if (time >= cool)
        {
            Instantiate(las, transform.position, transform.rotation);
            time = 0;
        }
    }

    public void SetKnd(int nextKnd)
    {
        knd = nextKnd;
    }

    public void LockOn(GameObject lTP)
    {
        for (int i = 0; i < miss.Count; i++)
        {
            miss[i].SetActive(true);
        }
        miss.Clear();
        for (int i = 0; i < enemys.Count; i++)
        {
            if (enemys[i] != null)
            {
                enemys[i].transform.tag = "Enemy";
            }
        }
        enemys.Clear();
        Destroy(lTP);
    }

    public void SetMiss(GameObject mis, GameObject enemy)
    {
        if (mis != null && enemy!=null)
        {
            miss.Add(mis);
            enemys.Add(enemy);
        }
        else
        {
            Debug.Log("null");
        }
    }
}
