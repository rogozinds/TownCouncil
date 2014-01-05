using UnityEngine;
using System.Collections;


public class GameStages : MonoBehaviour {
	public static int stageId=0;
	private int maxStages=5;
	public Texture2D leftArrowPic;
	public Texture2D rightArrowPic;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void moveBack() {
		if (stageId != 0) {
			stageId--;
		}
	}
	void moveForward() {
		if (stageId < maxStages - 1) {
			stageId++;
		}
	}
	void OnGUI() {
		Rect lArrow = new Rect (Screen.width-150,Screen.height-50,50,50);
		Rect rArrow = new Rect (Screen.width-90,Screen.height-50,50,50);
		if (GUI.Button (lArrow, leftArrowPic)) {
			moveBack ();
		}
		if (GUI.Button (rArrow, rightArrowPic)) {
			moveForward();
		}
	}
}
