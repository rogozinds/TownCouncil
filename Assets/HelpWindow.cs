using UnityEngine;
using System.Collections;

public class HelpWindow : MonoBehaviour {
	public GUISkin skin;
	public Texture2D circleTexture;
	public Texture2D commentPic;
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
		Rect cirlcePosition = new Rect (20,10,153,153);
		if (GameStages.stageId == 0) {
			text="Onneksi olkoon!";
			dialogue="Sinut on valittu kunnanvaltuustoon. Ensimmäinen tehtäväsi on luoda strategia, jota seuraat kautesi aikana. Strategiasta päätetään kunnanvaltuustossa. ";
		}
		if ((GameStages.stageId == 1) && (!JaneMoveScript.isMoving) ) {
			text="Valitse oma strategiasi.";
			dialogue="Suunnittele strategiasi lisäämällä pisteitä eri aloihin, kuten esimerkiksi koulutukseen tai " +
				"vanhustenhuoltoon. Jäljellä olevien pisteiden lukumäärän näet viereisestä kuvasta.";
		}
		if ((GameStages.stageId == 2) && (!JaneMoveScript.isMoving)) {
			text="Huom!";
			dialogue = "Olet kohdannut pelissä epäonnisen satunnaistapahtuman! Nämä tapahtuvat simuloivat " +
				"ennalta-arvaamattomia tilanteita, joilla on seurauksia kuntabudjetointiin";
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
		Color tmp = GUI.color;
		GUI.contentColor = Color.black;
		position.y += 30;
		position.x += 20;
		position.height -= 40;
		position.width -= 40;
		GUI.Label(position, dialogue);
		GUI.contentColor = tmp;

		//Adding Comment pic
		if ((GameStages.stageId > 0) && (!JaneMoveScript.isMoving)) {
			GUI.Label (new Rect (Screen.width-250,10,240,350),commentPic);
		}

	}

}
