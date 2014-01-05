using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;  

public class GreetingWindow : MonoBehaviour {
	private bool render=true;
	public Texture2D greetPic;
	private string greetText;
	public string greetingTextFile;
	void Start() {
		StreamReader theReader = new StreamReader(greetingTextFile, Encoding.Default);
		greetText = theReader.ReadToEnd();
	}
	void OnGUI() {
		Rect windowRect1 = new Rect(500, 200, 500, 300);
		if (render & GameStages.stageId==0) {
			windowRect1 = GUI.Window (0, windowRect1, DoWindow, "HEI HEI!");
		}
	}
	void DoWindow(int id) {
		Rect rect1 = new Rect (50, 50, 400, 400);
		GUILayout.BeginArea (rect1);
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayoutOption[] options = {GUILayout.Width(300),GUILayout.Height(100)};
		GUILayout.Label (greetPic,options);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		GUILayoutOption[]  options2 = {GUILayout.Width (300),GUILayout.Height(100)};
		GUILayout.FlexibleSpace ();
		greetText = GUILayout.TextArea(greetText,options2);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		render=!GUILayout.Button("OK");
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();
	}
	/*public Rect windowRect0 = new Rect(200, 200, 220, 250);
	public float var1=0.0f;
	void doFunc() {
		GUI.Label(new Rect(20,20,50,50),"sometext");
	}
	void OnGUI() {
				GUI.color = Color.red;
				windowRect0 = GUI.Window(0, windowRect0, doFunc, "Red Window");
				GUI.Label(windowRect0, "shit");
	}
	*/


}
