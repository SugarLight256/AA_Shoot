using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveMng : MonoBehaviour {

    public int currentWave;
    public List<GameObject> waves;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void NewWave()
    {
        currentWave++;
        if (currentWave >= waves.Count)
        {
            Application.LoadLevel(1);
        }
        else
        {
            Instantiate(waves[currentWave], transform.position, transform.rotation);
        }
    }

}
