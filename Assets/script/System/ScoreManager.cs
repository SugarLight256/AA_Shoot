﻿using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int score;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void AddScore(int additional)
    {
        score += additional * 100;
    }

}