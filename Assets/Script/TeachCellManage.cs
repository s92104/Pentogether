using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachCellManage : MonoBehaviour {
    public List<GameObject> touchcell;
    public GameObject[] cell;
    int a;
    int b;
    public GameObject[] btn;
    // Use this for initialization

    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {
        cell = GameObject.FindGameObjectsWithTag("Cell");
        a = cell.Length;
        for (int i = 0; i < a; i++)
        {
            if (cell[i].transform.childCount != 0)
            {
                if (!touchcell.Contains(cell[i].gameObject))
                    touchcell.Add(cell[i].gameObject);
            }
            else if (cell[i].transform.childCount == 0)
            {
                if (touchcell.Contains(cell[i].gameObject))
                    touchcell.Remove(cell[i].gameObject);
            }
        }
        b = touchcell.Count;

        Debug.Log(a);
        if (b == a)
        {
            for (int i=0;i< btn.Length;i++)
            btn[i].SetActive (true);
        } 
        else
        {
            for (int i = 0; i < btn.Length; i++)
                btn[i].SetActive(false);
        }     
    }
    public void Teach()
    {
        touchcell = new List<GameObject>();
    }
}
