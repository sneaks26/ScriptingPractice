using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript_Shu : MonoBehaviour {

    public bool trueOrFalse;
    public float decimalNumber = 5.0f;
    public float speed = 1.0f;
    public int aWholeNumber = 20;
    public string firstName = "sneaks";
    public int playerHealth;


	// Use this for initialization
	void Start () {
        Debug.Log("hello boo!");
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles += new Vector3 (0, speed, 0);
    }
}
