using UnityEngine;
using System.Collections;

public class ActivateTextAtLine : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public textBoxManager theTextBox;

	public bool requireButtonPress;

	private bool waitForPress;

	public bool destroyWhenActivated;

	// Use this for initialization
	void Start () {
		theTextBox = FindObjectOfType<textBoxManager> ();
		Debug.Log("start ATAL");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("update ATAL");
		if(waitForPress && Input.GetKeyDown(KeyCode.E))

		{
			Debug.Log("E");
			theTextBox.ReloadScript(theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnabletextBox();
			
			if (destroyWhenActivated)
			{
				Destroy(gameObject);
			}
		}
	
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("collided");

		if (other.tag == "Player") 
		{
			if (requireButtonPress)
			{
				waitForPress = true;
				return;
			}
            Debug.Log("I am a player");
				theTextBox.ReloadScript(theText);
				theTextBox.currentLine = startLine;
				theTextBox.endAtLine = endLine;
				theTextBox.EnabletextBox();

				if (destroyWhenActivated)
				{
					Destroy(gameObject);
				}
		}
	}

	void onTriggerExit(Collider other)
	{
		Debug.Log("exit collide");
		if (other.name == "FPSController") 
		{
			waitForPress = false;
		}
	}
}
