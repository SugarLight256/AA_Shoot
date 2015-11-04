using UnityEngine;
using System.Collections;

public class WaveObj : MonoBehaviour {

    private int ship_value;
    private WaveMng waveMng;

    public float turn;
    public bool mother;
    
	// Use this for initialization
	void Start () {
        waveMng = GameObject.Find("WaveMng").GetComponent<WaveMng>();
	}
	
	// Update is called once per frame
    void Update()
    {
        ship_value = transform.childCount;
        if (ship_value <= 0 && mother)
        {
            waveMng.NewWave();
            Destroy(transform.gameObject);
        }
        if (ship_value <= 0)
        {
            Destroy(transform.gameObject);
        }
        transform.Rotate(new Vector3(0f, 0f, turn));
	}

    public void shipDest()
    {
        ship_value--;
    }

}
