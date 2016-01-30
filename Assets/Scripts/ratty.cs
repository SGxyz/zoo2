using UnityEngine;
using System.Collections;

public class ratty : MonoBehaviour
{
    public Transform m_PlayerTransform;

    void Start()
    {
        InvokeRepeating("Jump", 3, 2);
    }

    void Update()
    {
        //transform.LookAt(m_PlayerTransform.position);
    }

    void Jump()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<Rigidbody>().AddForce(new Vector3(20, 300, 20), ForceMode.Force);
        //	GetComponent<Rigidbody>().AddForce(new Vector3(20, 300, 20), ForceMode.Force);
    }

}