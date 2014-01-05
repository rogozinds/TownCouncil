using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	public Transform target;
	public float smooth = 5.0F;
	void Start() {
	}
	void Update() {
		//Debug.Log (journeyLength.ToString ());
	}
}
