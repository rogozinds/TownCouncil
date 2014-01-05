using UnityEngine;
using System.Collections;

public class Stage1 : MonoBehaviour {
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
			Rect rect1 = new Rect (50, 50, 400, 200);
			GUI.Box(rect1,"");
			Rect rectSlider=new Rect(50,50,50,20);
			f1=CompLabelSlider.LabelSlider(rectSlider,f1,100,"Factor1");
			rectSlider.y+=20;
			f2=CompLabelSlider.LabelSlider(rectSlider,f2,100,"Factor1");
			rectSlider.y+=50;
			float f3=3;
			f3=GUI.HorizontalSlider(rectSlider,f3,0,10);
		}
	}
}
