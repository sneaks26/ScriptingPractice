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
    public float force = 10;
    public Color materialColor;

	// Use this for initialization
	void Start () {
        Debug.Log("hello boo!");
	}
	
	// Update is called once per frame
	void Update () {

        // Made the cube spin
        transform.eulerAngles += new Vector3 (0, speed, 0);

        // Cube is moving to the right
        //transform.position += new Vector3(speed, 0, 0);

        // Cube rotates on z axis
        //transform.Rotate(new Vector3(0, 0, speed));

        // Cube rotates on x axis
        //transform.Rotate(new Vector3(speed, 0, 0));

       

   }

    // Rigidbody force - new function - 
    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0, force, 0);


    }
        // Fade opacity of object
        public void Fade(float sliderValue) {
            materialColor.a = sliderValue;
            GetComponent<MeshRenderer>().material.color = materialColor;


    }
}
