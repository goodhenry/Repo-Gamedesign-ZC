using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// Draw the button, and invoke LoadLevel to start the game
	void OnGUI()
	{
		if (GUI.Button(new Rect(500, 200, 100, 50), "START"))
		{
			Invoke("LoadLevel", 1f);

		}
	}

	void LoadLevel() {
		Application.LoadLevel("CongaScene");
	}
}
