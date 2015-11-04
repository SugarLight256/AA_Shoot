using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class counter : MonoBehaviour {
    private Text myText;
    private Color myColor;
	// Use this for initialization
	void Start () {
        myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myColor = new Color(myText.color.r, myText.color.g, myText.color.b, myText.color.a - 0.0166667f);
        myText.color = myColor;
	}
}
