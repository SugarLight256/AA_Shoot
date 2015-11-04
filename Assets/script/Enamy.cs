using UnityEngine;
using System.Collections;

public class Enamy : MonoBehaviour {

    public int maxHP;
    public int HP;
    public float cool;
    public float coolMax;
    public GameObject bull;
    public int thisScore;
    public bool shot;
	// Use this for initialization
	void Start () {
        HP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {
        if (HP <= 0)
        {
            Destroy(transform.gameObject);
            ScoreManager.AddScore(thisScore);
        }
        if (coolMax <= cool && shot)
        {
            Instantiate(bull, transform.position, transform.rotation);
            cool = 0;
        }
        if (shot)
        {
            cool += Time.deltaTime;
        }
        transform.Rotate(new Vector3(0f,0f,2f));
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "P_bull")
        {
            HP--;
            Destroy(c.transform.gameObject);
        }
    }
}
