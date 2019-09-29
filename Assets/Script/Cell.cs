using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cell : MonoBehaviour {
    public int a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Tile") a=0;
        if (other.name == "V")
            a = 1;
        if (other.name == "L")
            a = 2;
        if (other.name == "X")
            a = 3;
        if (other.name == "P")
            a = 4;
        if (other.name == "F")
            a = 5;
        if (other.name == "T")
            a = 6;
        if (other.name == "W")
            a = 7;
        if (other.name == "Y")
            a = 8;
        if (other.name == "I")
            a = 9;
        if (other.name == "N")
            a = 10;
        if (other.name == "Z")
            a = 11;
        if (other.name == "U")
            a = 12;

    }
    /*void OnTriggerExit2D(Collider2D other)
    {
        a = 0;
    }*/
}
