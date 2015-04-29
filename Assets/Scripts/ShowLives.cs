using UnityEngine;
using System.Collections;

public class ShowLives : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Lives: " + ZombieController.getLives();
	}
}
