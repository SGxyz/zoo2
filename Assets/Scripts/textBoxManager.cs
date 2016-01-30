using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

//	public PlayerController FirstPersonCharacter;

	public bool isActive;

	public bool stopPlayerMovement;
	
	// Use this for initialization
	void Start () 
	{
//		FirstPersonCharacter = FindObjectOfType<PlayerController>();

		if(textFile != null)
			
		{
			// \n represents a line break (whenever our text file has an enter pressed)
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;
		}

		if (isActive) {
			EnabletextBox();
		}

		else {
			DisabletextBox();
		}

	}


	void Update()
	{
		if (!isActive)
		{
			return;
		}

		theText.text = textLines[currentLine];

		if(Input.GetKeyDown(KeyCode.E))
		{
			currentLine +=1;
		}


		if(currentLine > endAtLine) 
		{
			DisabletextBox();
		}

	}

	public void EnabletextBox()
	{
		textBox.SetActive(true);
		isActive = true;
		Debug.Log("enable text box");
        //		if (stopFirstPersonCharacterMovement) 
        //		{
        //			FirstPersonCharacter.canMove = false;
        //		}

    }

    public void DisabletextBox()
	{
        Debug.Log("textbox inactive");
		textBox.SetActive(false);
		isActive = false;

        //
        //		FirstPersonCharacter.canMove = true; 
        //
    }

    public void ReloadScript(TextAsset theText)
	{
			if(theText != null)
		{
			textLines = new string[1];
            // \n represents a line break (whenever our text file has an enter pressed)
            Debug.Log("new line");
			textLines = (theText.text.Split ('\n'));
		}
	}
}