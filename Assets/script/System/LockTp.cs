using UnityEngine;
using System.Collections;

public class LockTp : MonoBehaviour {

    private P_weapon player_wep;
    private Camera mainCam;
    public GameObject player;
    private AudioSource sound;
    public GameObject missile;
    public GameObject lockEffe;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        sound = GameObject.Find("lockSound").GetComponent<AudioSource>();
        player_wep = player.GetComponent<P_weapon>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1)
        {
            if (Input.touches[0].phase == TouchPhase.Moved)
            {
                transform.position = mainCam.ScreenToWorldPoint(Input.touches[0].position);
            }
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                player_wep.LockOn(transform.gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        GameObject tmpMis;
        if (c.transform.tag != "Locked_Enemy")
        {
            tmpMis = Instantiate(missile, player.transform.position, player.transform.rotation) as GameObject;
            tmpMis.SendMessage("SetTarget", c.gameObject);
            ((GameObject)Instantiate(lockEffe, c.transform.position, transform.rotation)).GetComponent<lockEffect>().SetTP(transform.gameObject, c.gameObject);
            c.transform.tag = "Locked_Enemy";
            sound.PlayOneShot(sound.clip);
            player_wep.SetMiss(tmpMis, c.gameObject);
            tmpMis.SetActive(false);
        }
    }
}
