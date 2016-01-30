using UnityEngine;
using System.Collections;

public class gameControler : MonoBehaviour {

    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
	    if(score == 1)
        {
            Debug.Log("You Win!!!");
            playWin();
            score = 0;
        }
	}

    public void updateScore()
    {
        score += 1;
    }

    public void playWin() {
        GetComponent<AudioSource>().Play();
}
}
