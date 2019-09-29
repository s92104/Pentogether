using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using MysqlAccess;

public class CellManage : MonoBehaviour
{
    public GameObject resultui;
    public GameObject repeattui;
    public GameObject result;
    public GameObject finishbg;
    public List<GameObject> touchcell;
    public GameObject[] cell;
    public GameObject[] cell2;
    public GameObject[] cell3;
    public GameObject[] cell4;
    public List<string> allsolution;
    public List<GameObject> solution;
    public bool cantake = true;
    public string solutioncode;
    public string solutioncode2;
    public string solutioncode3;
    public string solutioncode4;
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
        if (stage == 8)
            for (int i = 0; PlayerPrefs.HasKey("Solution08" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution08" + i));
            }
        if (stage == 9)
            for (int i = 0; PlayerPrefs.HasKey("Solution09" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution09" + i));
            }
        if (stage == 10)
            for (int i = 0; PlayerPrefs.HasKey("Solution10" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution10" + i));
            }
        if (stage == 11)
            for (int i = 0; PlayerPrefs.HasKey("Solution11" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution11" + i));
            }
        if (stage == 12)
            for (int i = 0; PlayerPrefs.HasKey("Solution12" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution12" + i));
            }
        if (stage == 13)
            for (int i = 0; PlayerPrefs.HasKey("Solution13" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution13" + i));
            }
        if (stage == 14)
            for (int i = 0; PlayerPrefs.HasKey("Solution14" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution14" + i));
            }
        if (stage == 15)
            for (int i = 0; PlayerPrefs.HasKey("Solution15" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution15" + i));
            }
        if (stage == 16)
            for (int i = 0; PlayerPrefs.HasKey("Solution16" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution16" + i));
            }
        if (stage == 17)
            for (int i = 0; PlayerPrefs.HasKey("Solution17" + i); i++)
            {
                allsolution.Add(PlayerPrefs.GetString("Solution17" + i));
            }


        //cell = GameObject.FindGameObjectsWithTag("Cell");
        a = cell.Length;

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
        if (a == b && stage == 8)
            Solution8();
        if (a == b && stage == 9)
            Solution9();
        if (a == b && stage == 10)
            Solution10();
        if (a == b && stage == 11)
            Solution11();
        if (a == b && stage == 12)
            Solution12();
        if (a == b && stage == 13)
            Solution13();
        if (a == b && stage == 14)
            Solution14();
        if (a == b && stage == 15)
            Solution15();
        if (a == b && stage == 16)
            Solution16();
        if (a == b && stage == 17)
            Solution17();
    }

    public void upload(int stage, string solution)
    {
        //Access.insertSolution(username, stage, solution);
    }

    public void Solution8()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution08" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution08" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(8, solutioncode);
        }
    }
    public void Solution9()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution09" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution09" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(9, solutioncode);
        }
    }
    public void Solution10()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution10" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution10" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(10, solutioncode);
        }
    }
    public void Solution11()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution11" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution11" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(11, solutioncode);
        }
    }
    public void Solution12()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution12" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution12" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(12, solutioncode);
        }
    }
    public void Solution13()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution13" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution13" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(13, solutioncode);
        }
    }
    public void Solution14()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution14" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution14" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(14, solutioncode);
        }
    }
    public void Solution15()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution15" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution15" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(15, solutioncode);
        }
    }
    public void Solution16()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
            }
            cantake = false;
            if (allsolution.Count == 0)
            {
                Debug.Log(solutioncode);
                Debug.Log("答案正確");
                allsolution.Add(solutioncode);
                for (int i = 0; i < allsolution.Count; i++)
                {
                    PlayerPrefs.SetString("Solution16" + i, allsolution[i]);
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
                    PlayerPrefs.SetString("Solution16" + j, allsolution[j]);
                }
                PlayerPrefs.Save();
                resultui.SetActive(true);
                finishbg.SetActive(false);
            }
            upload(16, solutioncode);
        }
    }
    public void Solution17()
    {
        if (cantake == true)
        {
            for (int i = 0; i < a; i++)
            {
                solutioncode = solutioncode + cell[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode2 = solutioncode2 + cell2[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode3 = solutioncode3 + cell3[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
                solutioncode4 = solutioncode4 + cell4[i].gameObject.GetComponentInChildren<Tile>().a.ToString();
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
                    if (solutioncode.Equals(allsolution[i]) || solutioncode2.Equals(allsolution[i]) || solutioncode3.Equals(allsolution[i]) || solutioncode4.Equals(allsolution[i]))
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
}

