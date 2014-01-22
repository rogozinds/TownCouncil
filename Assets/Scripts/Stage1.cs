using UnityEngine;
using System.Collections;

public class Stage1 : MonoBehaviour {
	public GUISkin skin;
	public Texture2D okPic;
	bool render = true;
	public int amountOfPoints = 100;
	private float[] slVals= new float[10];
	private string helpText = "";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		if (render) {
			if ((GameStages.stageId == 1) && (!JaneMoveScript.isMoving)) {
				GUI.skin = skin;
				Color tmp = GUI.color;
				GUI.contentColor=Color.black;
				Rect position = new Rect (400, 300, 550, 220);
				GUI.Box (position, "Määrittele parametrit");
				createSliders ();
				position.x += position.width - 150;
				position.y += 30;
				position.width = 150;
				if (GUI.tooltip.ToString () != "") {
					helpText = GUI.tooltip;
				}

				GUI.Label (position, helpText);
				GUI.contentColor=tmp;
				if (GUI.Button (new Rect (870, 460, 50, 50), okPic)) {
					render = false;
				}
			}
		}
	}

	void createSliders() {
		Rect rectSlider=new Rect(420,330,140,20);
		slVals[0]=CompLabelSlider.LabelSlider(rectSlider,slVals[0],100,"lapset ja perheet",
		                                      "päivähoito, kotihoidon tuki, perusopetus, lastensuojelun palvelut",skin);
		rectSlider.y+=30;
		
		slVals[1]=CompLabelSlider.LabelSlider(rectSlider,slVals[1],100,"ikäihmiset",
		                                      "kotona asumista tukevat palvelut, hoidon ja asumisen yhdistävät palvelut",skin);
		rectSlider.y+=30;
		slVals[2]=CompLabelSlider.LabelSlider(rectSlider,slVals[2],100,"työllisyys",
		                                      "työllistymisen tukeminen, ammatillinen koulutus, lukiokoulutus",skin);
		rectSlider.y+=30;
		slVals[3]=CompLabelSlider.LabelSlider(rectSlider,slVals[3],100,"elinkeinoelämä",
		                                      "yrittäjyyden tukeminen, tilojen ja tonttien tarjonta, aikuis- ja korkeakoulutuksen kehittäminen",skin);
		
		rectSlider.y+=30;
		slVals[4]=CompLabelSlider.LabelSlider(rectSlider,slVals[4],100,"liikunta",
		                                      "liikuntapaikkojen tarjoaminen, järjestöjen tukeminen, suurtapahtumien järjestämiseen osallistuminen",skin);
		rectSlider.y+=30;
		slVals[5]=CompLabelSlider.LabelSlider(rectSlider,slVals[5],100,"kulttuuri",
		                                      "tilojen tarjoaminen, järjestöjen tukeminen, suurtapahtumien järjestämiseen osallistuminen, kirjastot",skin);


	}
}
