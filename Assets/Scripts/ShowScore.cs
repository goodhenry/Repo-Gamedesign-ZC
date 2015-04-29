using UnityEngine;
using System.Collections;

public class ShowScore : MonoBehaviour {
/*	private int score = 11;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		score++;
		guiText.text = "Score: " + score;
	}*/

		
	void Update ()
	{

		// 设置GUI的文本
		guiText.text = "Score: " + ZombieController.getScore();

	}
}
