using UnityEngine;
using System.Collections;

public class AnimateGlobe : MonoBehaviour {

	public float speed = 30f;

	// Update is called once per frame
	void Update () {
		SpinGlobe ();
	}

	public void SpinGlobe () {
		// Continuously spin our Globe
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}

}