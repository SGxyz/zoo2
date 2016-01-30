using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {
	public Transform m_PlayerTransform;

void Start () {
		InvokeRepeating ("Jump", 3,Random.Range(2, 6));
}
	
void Update () {
        //transform.LookAt(m_PlayerTransform.position);
	}

void Jump () {
	GetComponent<AudioSource> ().Play ();
		GetComponent<Rigidbody>().AddForce(new Vector3(20, 300, 20), ForceMode.Force);
//	GetComponent<Rigidbody>().AddForce(new Vector3(20, 300, 20), ForceMode.Force);
} 

}