using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public float speed = 20f;
	public Vector3 axis;
	public Vector3 point;

    void Update() {
        transform.RotateAround(Vector3.zero, axis, speed * Time.deltaTime);
    }
}
