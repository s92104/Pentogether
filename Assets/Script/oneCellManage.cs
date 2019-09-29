using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using MysqlAccess;
public class oneCellManage : MonoBehaviour
{
    public GameObject resultui;
    public GameObject repeattui;
    public GameObject result;
    public GameObject finishbg;
    public List<GameObject> touchcell;
    public GameObject[] cell;
    public List<string> allsolution;
    public List<GameObject> solution;
    public bool cantake = true;
    public string solutioncode;
    int a;
    int b;
    int c;
    int d;
    public int stage;

    public string username;
    // Use this for initialization


    void Start()
    {
       // PlayerPrefs.DeleteAll();
        if (stage == 1)
            for (int i = 0; PlayerPrefs.HasKey("Solution01" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution01" + i));
            }
        if (stage == 2)
            for (int i = 0; PlayerPrefs.HasKey("Solution02" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution02" + i));
            }
        if (stage == 5)
            for (int i = 0; PlayerPrefs.HasKey("Solution05" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution05" + i));
            }
        if (stage == 6)
            for (int i = 0; PlayerPrefs.HasKey("Solution06" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution06" + i));
            }
        if (stage == 17)
            for (int i = 0; PlayerPrefs.HasKey("Solution17" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution17" + i));
            }
        if (stage == 18)
            for (int i = 0; PlayerPrefs.HasKey("Solution18" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution18" + i));
            }
        if (stage == 19)
            for (int i = 0; PlayerPrefs.HasKey("Solution19" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution19" + i));
            }
        if (stage == 20)
            for (int i = 0; PlayerPrefs.HasKey("Solution20" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution20" + i));
            }
        if (stage == 21)
            for (int i = 0; PlayerPrefs.HasKey("Solution21" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution21" + i));
            }
        if (stage == 22)
            for (int i = 0; PlayerPrefs.HasKey("Solution22" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution22" + i));
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
        if (a == b && stage == 1)
            Solution1();
        if (a == b && stage == 2)
            Solution2();
        if (a == b && stage == 5)
            Solution5();
        if (a == b && stage == 6)
            Solution6();
        if (a == b && stage == 17)
            Solution17();
        if (a == b && stage == 18)
            Solution18();
        if (a == b && stage == 19)
            Solution19();
        if (a == b && stage == 20)
            Solution20();
        if (a == b && stage == 21)
            Solution21();
        if (a == b && stage == 22)
            Solution22();

    }

	public void upload(int stage,string solution)
	{
        //Access.insertSolution(username, stage, solution);
	}

    public void Solution1()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution01" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution01" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(1, solutioncode);
        }
    }
    public void Solution2()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution02" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution02" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(2, solutioncode);
        }
    }
    public void Solution5()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution05" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution05" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(5, solutioncode);
        }
    }
    public void Solution6()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution06" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution06" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(6, solutioncode);
        }
    }
    public void Solution17()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution17" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution17" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(17, solutioncode);
        }
    }
    public void Solution18()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution18" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution18" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(18, solutioncode);
        }
    }
    public void Solution19()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution19" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution19" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(19, solutioncode);
        }
    }
    public void Solution20()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution20" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution20" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(20, solutioncode);
        }
    }
    public void Solution21()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution21" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution21" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(21, solutioncode);
        }
    }
    public void Solution22()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;

            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution22" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution22" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(22, solutioncode);
        }
    }
}
