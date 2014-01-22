using UnityEngine;
using System.Collections;

public class FireStage : MonoBehaviour {
	public Texture2D attentPic;
	private Object fires;
	Component[] particles;
	Light childLight;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GameObject[] fires = GameObject.FindGameObjectsWithTag("FireTag");
			// Init the particles to not emit and switch off the spotlights:

		foreach (GameObject fire in fires) {
			childLight = fire.GetComponentInChildren<Light>();

			ParticleSystem particlesystem = (ParticleSystem)fire.GetComponent("ParticleSystem");
			if ((GameStages.stageId == 2) && (JaneMoveScript.isMoving==false)) {
				childLight.enabled=true;
				particlesystem.enableEmission = true;
				GUI.Label(new Rect (420, 300, 550, 220),attentPic);

			} else {
				childLight.enabled=false;
				particlesystem.enableEmission = false;
			}
		}
	}
}
