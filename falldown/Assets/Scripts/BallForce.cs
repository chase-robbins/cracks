using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour {

	// Use this for initialization
	[Tooltip("This is how fast the thing moves!")]
	public float speed = 10;
	public bool canFly = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float y = 0;
		float x = Input.GetAxis ("Horizontal");
		if(canFly == true)
		{
			y = Input.GetAxis ("Vertical");
		}
		if (x != 0 || y != 0)
		{
			Rigidbody2D r2d = GetComponent<Rigidbody2D>();
			Vector2 direction = r2d.velocity;
			if(x !=0) {direction.x = x * speed; }
			if(y !=0) {direction.y = y * speed; }
			r2d.velocity = direction;
		}

		if(Camera.main.transform.position.y + Camera.main.rect.height/2 < transform.position.y){
		}
	}
}