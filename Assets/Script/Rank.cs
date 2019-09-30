using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MysqlAccess;
using UnityEngine.UI;

public class Rank : MonoBehaviour {
    public GameObject rankWindow,rankRow,content;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void rank()
    {
        if (!Access.isConnect())
            return;

        List<User> result = Access.rank();
        int rank = 0;
        int rec = 0;
        for (int i = 0; i < result.Count; i++)
        {
            int score = result[i].getScore();
            if(score!=rec)
            {
                rank++;
                rec = score;
            }
            rankRow.transform.GetChild(0).GetComponent<Text>().text = rank.ToString();
            rankRow.transform.GetChild(1).GetComponent<Text>().text = result[i].getUsername();
            rankRow.transform.GetChild(2).GetComponent<Text>().text = result[i].getScore().ToString();

            content.AddChild(rankRow);
        }

        rankWindow.SetActive(true);
    }
}
