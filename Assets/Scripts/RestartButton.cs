using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(500, 200, 100, 50), "RESTART"))
		{
			Invoke("LoadLevel", 1f);
			
		}
	}
	
	void LoadLevel() {
		Application.LoadLevel("CongaScene");
	}
}
