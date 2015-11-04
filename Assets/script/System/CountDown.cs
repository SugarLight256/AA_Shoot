using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CountDown : MonoBehaviour {
    public List<GameObject> countTxt;
    public GameObject TimeManager;
    private bool timerFlag=false;
    private TimeManager timeChanger;
    private float timer=0;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < countTxt.Count; i++)
        {
            countTxt[i].SetActive(false);
        }
        timeChanger = TimeManager.GetComponent<TimeManager>();
        timeChanger.timeScaleChanger(0);
	}
	
	// Update is called once per frame
	void Update () {
        if (timerFlag)
        {
            timer += 0.0166666667f;
        }
        switch ((int)timer)
        {
            case 1:
                countTxt[0].SetActive(true);
                break;
            case 2:
                countTxt[1].SetActive(true);
                break;
            case 3:
                countTxt[2].SetActive(true);
                break;
            case 4:
                countTxt[3].SetActive(true);
                timeChanger.timeScaleChanger(1);
                TimeManager.GetComponent<Timer>().timerFlag = true;
                break;
        }
	}
    public void SetTimerFlag(bool flag)
    {
        timerFlag = flag;
    }
}
