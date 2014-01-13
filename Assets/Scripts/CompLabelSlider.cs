using UnityEngine;
using System.Collections;

public class CompLabelSlider : MonoBehaviour {		
	public static float LabelSlider (Rect screenRect, float sliderValue, float sliderMaxValue, string labelText,string tooltipText="",GUISkin skin=null) {
		GUISkin defaultSkin = GUI.skin;
		if (skin != null) {
			GUI.skin = skin;
		}
		GUI.Label (screenRect, labelText);
		
		// &lt;- Push the Slider to the end of the Label
		screenRect.x += screenRect.width; 
		sliderValue = GUI.HorizontalSlider (screenRect, sliderValue, 0.0f, sliderMaxValue);
		GUI.Box (screenRect, new GUIContent ("", tooltipText), GUIStyle.none);
		screenRect.y += 10;
		GUI.skin = defaultSkin;
		return sliderValue;
	}
	
}
