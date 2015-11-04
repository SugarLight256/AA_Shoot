using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float timer;
    public bool timerFlag;
    public Text timerTxt;
    public GameObject timerObj;

	// Use this for initialization
	void Start () {
        timerTxt = timerObj.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (timerFlag)
        {
            timer += Time.deltaTime;
        }
        if (30-timer <= 0)
        {
            Application.LoadLevel(1);
            //ゲームオーバー
        }
        if (30 - timer <= 5)
        {
            timerTxt.color = new Color(255, 0, 0, 255);
        }else if (30 - timer <= 10)
        {
            timerTxt.color = new Color(255, 255, 0, 255);
        }
        else
        {
            timerTxt.color = new Color(0, 255, 0, 255);
        }
        timerTxt.text = "Time : " + (30 - timer);
	}
}
