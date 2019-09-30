using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using MysqlAccess;
using UnityEngine.SceneManagement;

public class Account : MonoBehaviour {
    public GameObject loginWindow, accountWindow,registerWindow;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void checkLogin()
    {
        if (!Access.isConnect())
            return;

        if (PlayerPrefs.HasKey("username"))
        {
            string username = PlayerPrefs.GetString("username");
            accountWindow.transform.GetChild(0).GetComponent<Text>().text = "帳號:"+username;
            accountWindow.transform.GetChild(1).GetComponent<Text>().text = "分數:"+Access.selectScore(username).ToString();
            
            accountWindow.SetActive(true);
        }
        else
            loginWindow.SetActive(true);
    }

    public void register()
    {
        string username = registerWindow.transform.GetChild(0).gameObject.GetComponent<InputField>().text;
        string password = registerWindow.transform.GetChild(1).gameObject.GetComponent<InputField>().text;
        if (!Access.checkUsername(username))
        {
            Access.insertUser(username, password);
            registerWindow.SetActive(false);
            loginWindow.SetActive(true);
        }
        else
            Debug.Log("No");
    }

    public void login()
    {
        string username = loginWindow.transform.GetChild(0).gameObject.GetComponent<InputField>().text;
        string password = loginWindow.transform.GetChild(1).gameObject.GetComponent<InputField>().text;

        if (Access.checkUser(username, password))
        {
            PlayerPrefs.SetString("username", username);
            loginWindow.SetActive(false);
        }
        else
            Debug.Log("No");
    }

    public void logout()
    {
        PlayerPrefs.DeleteKey("username");
        accountWindow.SetActive(false);
    }

    public void upload()
    {
    	string username=PlayerPrefs.GetString("username");
        List<string>[] local=getSolution();
        List<string>[] online = Access.selectSolution(username);
        List<int>[] solutionCount = Access.selectSolutionCount(username);
        int score = Access.selectScore(username);

        //分數
        int[] levelScore = { 10, 20, 30, 40, 50, 50, 50, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500 };

        for (int i = 0; i < local[0].Count; i++)
        {
            bool duplicate = false;
            for(int j=0;j<online[0].Count;j++)
            {
                //重複
                if (local[0][i] == online[0][j] && local[1][i] == online[1][j])
                {
                    duplicate = true;
                    break;
                }
            }
            //不重複
            if (!duplicate)
            {
                //上傳Solution
                Access.insertSolution(username, local[0][i], local[1][i]);
                //判斷第幾關
                int stage = int.Parse(local[0][i].Substring(8));
                //加Score
                score += levelScore[stage - 1];
                //加Solution Count
                bool hasRecord = false;
                for(int j=0;j<solutionCount[0].Count;j++)
                {
                    //有紀錄
                    if (stage == solutionCount[0][j])
                    {
                        solutionCount[1][j]++;
                        hasRecord = true;
                        break;
                    }
                }
                //沒紀錄
                if(!hasRecord)
                {
                    Access.insertSolutionCount(username, stage, 1);
                    solutionCount[0].Add(stage);
                    solutionCount[1].Add(1);
                }
            }
        }
        //上傳Score
        Access.updateScore(username, score);
        //上傳Solution Count
        for (int i = 0; i < solutionCount[0].Count; i++)
            Access.updateSolutionCount(username, solutionCount[0][i], solutionCount[1][i]);
    }


    public void download()
    {
    	string username=PlayerPrefs.GetString("username");
    	List<string>[] solution=Access.selectSolution(username);
        List<int>[] solutionCount = Access.selectSolutionCount(username);
        int score = Access.selectScore(username);

        //更新紀錄
        //下載Solution
        for (int i = 1; i < 23; i++)
        {
            string recordName = "Solution";
            if (i < 10)
                recordName += "0";
            recordName += i;

            int count = 0;
            for (int j = 0; j < solution[0].Count; j++)
            {
                if (solution[0][j] == recordName)
                {
                    PlayerPrefs.SetString(solution[0][j] + count, solution[1][j]);
                    count++;
                }
            }
        }
        //下載Solution Count
        for (int i = 0; i < solutionCount[0].Count; i++)
        {
            string stage = "a";
            if (solutionCount[0][i] == 1)
                stage += "a";
            stage += solutionCount[0][i];
            PlayerPrefs.SetInt(stage, solutionCount[1][i]);
        }
        //下載Score
        PlayerPrefs.SetInt("scorevalue", score);
        //更新畫面
        accountWindow.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    List<string>[] getSolution()
    {
        List<string> solution=new List<string>();
        List<string> stage = new List<string>();

        for (int i = 1; i < 23; i++)
        {
            string recordName = "Solution";
            if (i < 10)
                recordName += "0";
            recordName += i;

            for (int j = 0; PlayerPrefs.HasKey(recordName + j); j++)
            {
                stage.Add(recordName);
                solution.Add(PlayerPrefs.GetString(recordName + j));
            }
        }

        List<string>[] result= {stage,solution};
        return result;
    }
}
