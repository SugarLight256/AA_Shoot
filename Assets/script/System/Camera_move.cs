using UnityEngine;
using System.Collections;

public class Camera_move : MonoBehaviour {

    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
    void Update()
    {
        float x=0, y=0;
        if (player.transform.position.y <= 200 - 50 && player.transform.position.y >= -200 + 50)
        {
            y = (player.transform.position.y - transform.position.y) / 50;
        }
        if (player.transform.position.x <= 200 - 80 && player.transform.position.x >= -200 + 80)
        {
            x = (player.transform.position.x - transform.position.x) / 50;
        }
        transform.position = new Vector3(transform.position.x + x, transform.position.y + y, -10);
    }
}
