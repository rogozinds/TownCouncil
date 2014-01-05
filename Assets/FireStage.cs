using UnityEngine;
using System.Collections;

public class FireStage : MonoBehaviour {
	private Object fires;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GameObject[] fires = GameObject.FindGameObjectsWithTag("FireTag");
		foreach (GameObject fire in fires) {
			if (GameStages.stageId == 2) {
				fire.renderer.enabled=true;
				Debug.Log ("FIre on");

			} else {
				fire.renderer.enabled=false;
				Debug.Log ("FIre off");
			}
		}
	}
}
