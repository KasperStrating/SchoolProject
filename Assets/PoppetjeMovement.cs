using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoppetjeMovement : MonoBehaviour {

    public GameObject poppetje;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(poppetje.active);
	}
}
