using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSprite : MonoBehaviour {
    public Sprite[] cellcolor;
    public string color;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (color == "V")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[1];
        }
        if (color == "L")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[0];
        }
        if (color == "X")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[2];
        }
        if (color == "P")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[3];
        }
        if (color == "F")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[4];
        }
        if (color == "T")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[5];
        }
        if (color == "W")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[6];
        }
        if (color == "Y")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[7];
        }
        if (color == "I")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[8];
        }
        if (color == "N")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[9];
        }
        if (color == "Z")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[10];
        }
        if (color == "U")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[11];
        }
        if (color == "B")
        {
            GetComponent<SpriteRenderer>().sprite = cellcolor[12];
        }

    }
}
