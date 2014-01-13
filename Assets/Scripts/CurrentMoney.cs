using UnityEngine;
using System.Collections;

public class CurrentMoney : MonoBehaviour {
	public Texture2D houseIcon;
	public Texture2D circle;
	public int curStage;
	public string stringToEdit;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI() {
		drawNavMap ();
	}
	void DrawQuad(Rect position, Color color,string text="") {
		Texture2D texture = new Texture2D(1, 1);
		texture.SetPixel(0,0,color);
		texture.Apply();
		Texture2D tmp = GUI.skin.box.normal.background;
		GUI.skin.box.normal.background = texture;
		GUI.Box (position, text);
		GUI.skin.box.normal.background = tmp;
	}
	private void drawNavMap() {
		int BEGIN_POS_X=10;
		int BEGIN_POS_Y = Screen.height - 180;
		int DIST_ICONS = 150;
		int ICON_SIZE = 200;
		int HOUSES_N = 5;
		Color c=new Color(1.0f,1.0f,(float)222/255);
		curStage = GameStages.stageId;

		GUI.DrawTexture (new Rect (BEGIN_POS_X+DIST_ICONS*curStage+8, BEGIN_POS_Y+50, ICON_SIZE-50, ICON_SIZE-50), circle);
		for (int i=0; i<HOUSES_N; i++) {
			int xpos=BEGIN_POS_X+DIST_ICONS*i;
			DrawQuad(new Rect(xpos+80,BEGIN_POS_Y+140,10,30),c);
			GUI.DrawTexture (new Rect (xpos, BEGIN_POS_Y, ICON_SIZE, ICON_SIZE), houseIcon);

		}
		for (int i=0; i<HOUSES_N-1; i++) {
			int xpos=BEGIN_POS_X+DIST_ICONS*i;
			DrawQuad(new Rect(xpos+80,BEGIN_POS_Y+160,DIST_ICONS,10),c);
		}
	}
}
