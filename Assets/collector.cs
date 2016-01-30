using UnityEngine;
using System.Collections;

public class collector : MonoBehaviour {

    public gameControler gameControler;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider other)
        {
            if (other.tag == "key")
            {
                gameControler.updateScore();
                Destroy(other.gameObject);

            GameObject[] cageObjects;
            GameObject[] talkObjects;
            cageObjects = GameObject.FindGameObjectsWithTag("cage");
            talkObjects = GameObject.FindGameObjectsWithTag("talk");

            for (var i = 0; i < cageObjects.Length; i++)
            {
                Destroy(cageObjects[i]);
            }

            for (var i = 0; i < talkObjects.Length; i++)
            {
                Destroy(talkObjects[i]);
            }
        }
        }
 

}
