using UnityEngine;
using System.Collections;

public class smallZombieController : MonoBehaviour {

	private Vector3 moveDirection;
	public float moveSpeed;

	private bool isInvincible = false;
	private float timeSpentInvincible;

	// Use this for initialization
	void Start () {
		moveDirection = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		int lives = ZombieController.getLives ();

		Vector3 target = moveDirection * moveSpeed + currentPosition;
		transform.position = Vector3.Lerp( currentPosition, target, Time.deltaTime );

		if ( lives == 2 ){
			Destroy( gameObject ); 
		}

	}

	/*public void OnBecameInvisible() {
		int lives = ZombieController.getLives();
		if ( lives == 2 )
			Destroy( gameObject ); 
	}*/
}
