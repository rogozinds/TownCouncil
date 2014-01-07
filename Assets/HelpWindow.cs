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
			text="Greetings!";
			dialogue="You are in the TownCouncil Game!";
		}
		if (GameStages.stageId == 1 ) {
			text="Select your strategy.";
			dialogue="In this stage you have to specify your strategy. Use the sliders." +
				"To get info about each factor just point on the specific slider.";
		}
		if (GameStages.stageId == 2 ) {
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
		scrollPosition = GUI.BeginScrollView(position, scrollPosition, new Rect(5, 5, 287, 200));
				
		// Put something inside the ScrollView
		
		string innerText = GUI.TextArea(new Rect(5, 5, 287, textLength), dialogue);

		// End the ScrollView
		
		GUI.EndScrollView();

	}

}
