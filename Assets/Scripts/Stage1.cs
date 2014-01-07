using UnityEngine;
using System.Collections;

public class Stage1 : MonoBehaviour {
	public GUISkin skin;
	public int amountOfPoints = 100;
	public float f1=0;
	private float f2=2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		if (GameStages.stageId == 1) {
			GUI.skin = skin;	
			Rect position = new Rect (400, 300, 400, 200);
			GUI.Box(position,"Specify parameters");
			Rect rectSlider=new Rect(420,330,150,20);
			f1=CompLabelSlider.LabelSlider(rectSlider,f1,100,"lapset ja perheet",
			                               "päivähoito, kotihoidon tuki, perusopetus, lastensuojelun palvelut",skin);
			rectSlider.y+=20;

			f2=CompLabelSlider.LabelSlider(rectSlider,f2,100,"ikäihmiset","Some info",skin);


			position.x+=position.width+10;
			position.width=150;
			if (GUI.tooltip!="") {
				GUI.Box(position,"");
				GUI.Label(position, GUI.tooltip);
			}
			rectSlider.y+=50;
		}
	}
}
