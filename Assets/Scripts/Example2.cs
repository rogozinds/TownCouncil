using UnityEngine;
using UnityEditor;
public class Example2 : EditorWindow {
	string myString = "Hello World";
	bool groupEnabled;
	bool myBool = true;
	float myFloat = 1.23f;
	
	// Add menu named "My Window" to the Window menu
	[MenuItem ("Window/My Window")]
	static void Init () {
		// Get existing open window or if none, make a new one:
		Example2 window = (Example2)EditorWindow.GetWindow (typeof (Example2));
	}
	
	void OnGUI () {
		GUILayout.Label ("Base Settings", EditorStyles.boldLabel);
		myString = EditorGUILayout.TextField ("Text Field", myString);
		
		groupEnabled = EditorGUILayout.BeginToggleGroup ("Optional Settings", groupEnabled);
		myBool = EditorGUILayout.Toggle ("Toggle", myBool);
		myFloat = EditorGUILayout.Slider ("Slider", myFloat, -3, 3);
		EditorGUILayout.EndToggleGroup ();
		EditorGUILayout.HelpBox("Some help stuff",MessageType.Info);
		Example2 wind = new Example2();

	}
}