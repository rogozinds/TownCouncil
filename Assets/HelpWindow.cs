using UnityEngine;
using System.Collections;

public class HelpWindow : MonoBehaviour {
	public GUISkin skin;
	public Texture2D circleTexture;
	private string text;
	private string dialogue;
	private int textLength = 335;
	private Vector2 scrollPosition;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI() {
		skin.box.fontSize = 20;
		GUI.skin = skin;

		Rect position = new Rect (200,10,300,153);
		Rect cirlcePosition = new Rect (20,10,200,200);
		if (GameStages.stageId == 0) {
			text="Onneksi olkoon!";
			dialogue="Sinut on valittu kunnanvaltuustoon. Ensimmäinen tehtäväsi on luoda strategia, jota seuraat kautesi aikana. Strategiasta päätetään kunnanvaltuustossa. ";
		}
		if ((GameStages.stageId == 1) && (!JaneMoveScript.isMoving) ) {
			text="Select your strategy.";
			dialogue="In this stage you have to specify your strategy. Use the sliders." +
				"To get info about each factor just point on the specific slider.";
		}
		if ((GameStages.stageId == 2) && (!JaneMoveScript.isMoving)) {
			text="OOOPS!";
			dialogue = "Unexpected situation appeared. You have to reconsider your strategy.";
		}
		if (GameStages.stageId == 3 ) {
			text="Stage 3";
			dialogue = "Test data.";
		}
		if (GameStages.stageId == 4 ) {
			text="Stage 4";
			dialogue = "Test data.";
		}
		GUI.Label(cirlcePosition, circleTexture);
		GUI.Box(position, text);
		position.y += 30;
		position.x += 20;
		position.height -= 40;
		position.width -= 40;
		GUI.Label(position, dialogue);
	}

}
