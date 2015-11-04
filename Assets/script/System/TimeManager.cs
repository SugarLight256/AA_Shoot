using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void timeScaleChanger(float newTimeScale)
    {
        Time.timeScale = newTimeScale;
    }
}
