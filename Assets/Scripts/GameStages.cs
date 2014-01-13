using UnityEngine;
using System.Collections;


public class GameStages : MonoBehaviour {
	public static int stageId=0;
	public GUISkin skin;
	private int maxStages=5;
	public Texture2D savePic;
	public Texture2D loadPic;
	public Texture2D helpPic;
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
		GUI.skin = skin;
		/*
		Rect lArrow = new Rect (Screen.width-150,Screen.height-50,50,50);
		if (GUI.Button (lArrow, leftArrowPic)) {
			moveBack ();
		}
		*/
		Rect helpRec = new Rect (Screen.width-255,Screen.height-70,50,50);
		Rect loadRec = new Rect (Screen.width-200,Screen.height-70,50,50);
		Rect saveRec = new Rect (Screen.width-145,Screen.height-70,50,50);
		Rect rArrow = new Rect (Screen.width-90,Screen.height-70,50,50);
		//Buttons which are not pressed
		GUI.Button (helpRec, helpPic);
		GUI.Button (loadRec, loadPic);
		GUI.Button (saveRec, savePic);

		//
		if (GUI.Button (rArrow, rightArrowPic)) {
			moveForward();
			JaneMoveScript.isMoving=true;
		}

	}
}
