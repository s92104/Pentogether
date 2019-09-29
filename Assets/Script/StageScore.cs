using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScore : MonoBehaviour {
    public int a;
    public GameObject Score;
    public GameObject None;
    public GameObject Already;
    public int newscorevalue;
    public int a1;
    public int a2;

    // Use this for initialization
    void Start () {
        if (a==1)
        {
         a1 = PlayerPrefs.GetInt("aa1");
         a2 = 1-a1;
        }
        if (a == 2)
        {
            a1 = PlayerPrefs.GetInt("a2");
            a2 = 7-a1;
        }
        if (a == 3)
        {
            a1 = PlayerPrefs.GetInt("a3");
            a2 = 1 - a1;
        }
        if (a == 4)
        {
            a1 = PlayerPrefs.GetInt("a4");
            a2 = 1 - a1;
        }
        if (a == 5)
        {
            a1 = PlayerPrefs.GetInt("a5");
            a2 = 7 - a1;
        }
        if (a == 6)
        {
            a1 = PlayerPrefs.GetInt("a6");
            a2 = 1 - a1;
        }
        if (a == 7)
        {
            a1 = PlayerPrefs.GetInt("a7");
            a2 = 4 - a1;
        }
        if (a == 8)
        {
            a1 = PlayerPrefs.GetInt("a8");
            a2 = 7 - a1;
        }
        if (a == 9)
        {
            a1 = PlayerPrefs.GetInt("a9");
            a2 = 50 - a1;
        }
        if (a == 10)
        {
            a1 = PlayerPrefs.GetInt("a10");
            a2 = 541 - a1;
        }
        if (a == 11)
        {
            a1 = PlayerPrefs.GetInt("a11");
            a2 = 1396 - a1;
        }
        if (a == 12)
        {
            a1 = PlayerPrefs.GetInt("a12");
            a2 = 3408 - a1;
        }
        if (a == 13)
        {
            a1 = PlayerPrefs.GetInt("a13");
            a2 = 5902 - a1;
        }
        if (a == 14)
        {
            a1 = PlayerPrefs.GetInt("a14");
            a2 = 6951 - a1;
        }
        if (a == 15)
        {
            a1 = PlayerPrefs.GetInt("a15");
            a2 = 4103 - a1;
        }
        if (a == 16)
        {
            a1 = PlayerPrefs.GetInt("a16");
            a2 = 2339 - a1;
        }
        if (a == 17)
        {
            a1 = PlayerPrefs.GetInt("a17");
            a2 =3 - a1;
        }
        if (a == 18)
        {
            a1 = PlayerPrefs.GetInt("a18");
            a2 = 125 - a1;
        }
        if (a == 19)
        {
            a1 = PlayerPrefs.GetInt("a19");
            a2 = 113 - a1;
        }
        if (a == 20)
        {
            a1 = PlayerPrefs.GetInt("a20");
            a2 = 68 - a1;
        }
        if (a == 21)
        {
            a1 = PlayerPrefs.GetInt("a21");
            a2 = 497 - a1;
        }
        if (a == 22)
        {
            a1 = PlayerPrefs.GetInt("a22");
            a2 = 86 - a1;
        }
        newscorevalue = PlayerPrefs.GetInt("scorevalue");
      

        Score.gameObject.GetComponent<Text>().text = "" + newscorevalue;
        None.gameObject.GetComponent<Text>().text = "未解：" + a2 + "組";
        Already.gameObject.GetComponent<Text>().text = "已解：" + a1+ "組";


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
