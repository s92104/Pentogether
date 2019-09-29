using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using MysqlAccess;

public class TwoCellManage : MonoBehaviour
{
    public GameObject resultui;
    public GameObject repeattui;
    public GameObject result;
    public GameObject finishbg;
    public List<GameObject> touchcell;
    public GameObject[] cell;
    public GameObject[] cell2;
    public List<string> allsolution;
    //public List<string> allresult;
    public List<GameObject> solution;
    public bool cantake = true;
    public string solutioncode;
    public string solutioncode2;
    int a;
    int b;
    int c;
    int d;
    public int stage;

    public string username;
    // Use this for initialization


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (stage == 3)
            for (int i = 0; PlayerPrefs.HasKey("Solution03" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution03" + i));
            }
        if (stage == 4)
            for (int i = 0; PlayerPrefs.HasKey("Solution04" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution04" + i));
            }
        if (stage == 7)
            for (int i = 0; PlayerPrefs.HasKey("Solution07" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution07" + i));
            }
        //cell = GameObject.FindGameObjectsWithTag("Cell");
        a = cell.Length;
        Vector2 startingPos = result.transform.position;

        username = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        b = touchcell.Count;
        //Debug.Log(a+""+b+""+c);
        // cell = GameObject.FindGameObjectsWithTag("Cell");
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
        /* foreach (int value in cellvalue)
         {
             Debug.Log(value);
         }*/
        if (a == b && stage == 3)
            Solution3();
        if (a == b && stage == 4)
            Solution4();
        if (a == b && stage == 7)
            Solution7();

    }

    public void upload(int stage, string solution)
    {
        //Access.insertSolution(username, stage, solution);
    }

    public void Solution3()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution03" + i, allsolution[i]);
                }
                PlayerPrefs.Save();
                Debug.Log("存檔1");
                resultui.SetActive(true);
                finishbg.SetActive(false);
                //CamCapture();
            }
            else if (allsolution.Count != 0)
            {
                for (int i = 0; i < allsolution.Count; i++)
                {
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) )
                    {
                        Debug.Log("答案重複");
                        repeattui.SetActive(true);
                        finishbg.SetActive(false);
                        return;
                    }
                }
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int j = 0; j < allsolution.Count; j++)
                {
                    PlayerPrefs.SetString("Solution03" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(3, solutioncode);
        }
    }
    public void Solution4()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution04" + i, allsolution[i]);
                }
                PlayerPrefs.Save();
                Debug.Log("存檔1");
                resultui.SetActive(true);
                finishbg.SetActive(false);
                //CamCapture();
            }
            else if (allsolution.Count != 0)
            {
                for (int i = 0; i < allsolution.Count; i++)
                {
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]))
                    {
                        Debug.Log("答案重複");
                        repeattui.SetActive(true);
                        finishbg.SetActive(false);
                        return;
                    }
                }
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int j = 0; j < allsolution.Count; j++)
                {
                    PlayerPrefs.SetString("Solution04" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(4, solutioncode);
        }
    }
    public void Solution7()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution07" + i, allsolution[i]);
                }
                PlayerPrefs.Save();
                Debug.Log("存檔1");
                resultui.SetActive(true);
                finishbg.SetActive(false);
                //CamCapture();
            }
            else if (allsolution.Count != 0)
            {
                for (int i = 0; i < allsolution.Count; i++)
                {
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]))
                    {
                        Debug.Log("答案重複");
                        repeattui.SetActive(true);
                        finishbg.SetActive(false);
                        return;
                    }
                }
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int j = 0; j < allsolution.Count; j++)
                {
                    PlayerPrefs.SetString("Solution07" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(7, solutioncode);
        }
    }
}
