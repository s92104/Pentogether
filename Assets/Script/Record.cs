
using UnityEngine;
using System.Collections;
using MysqlAccess;

public class Record : MonoBehaviour
{
    public int a1;
    public int a2;
    public int a3;
    public int a4;
    public int a5;
    public int a6;
    public int a7;
    public int a8;
    public int a9;
    public int a10;
    public int a11;
    public int a12;
    public int a13;
    public int a14;
    public int a15;
    public int a16;
    public int a17;
    public int a18;
    public int a19;
    public int a20;
    public int a21;
    public int a22;
    public int a23;
    public int a24;
    public int scorevalue;

    public int newa1;
    public int newa2;
    public int newa3;
    public int newa4;
    public int newa5;
    public int newa6;
    public int newa7;
    public int newa8;
    public int newa9;
    public int newa10;
    public int newa11;
    public int newa12;
    public int newa13;
    public int newa14;
    public int newa15;
    public int newa16;
    public int newa17;
    public int newa18;
    public int newa19;
    public int newa20;
    public int newa21;
    public int newa22;
    public int newa23;
    public int newa24;
    public int newscorevalue;

    public string username;

    void Start()
    {
        a1 = PlayerPrefs.GetInt("aa1");
        a2 = PlayerPrefs.GetInt("a2");
        a3 = PlayerPrefs.GetInt("a3");
        a4 = PlayerPrefs.GetInt("a4");
        a5 = PlayerPrefs.GetInt("a5");
        a6 = PlayerPrefs.GetInt("a6");
        a7 = PlayerPrefs.GetInt("a7");
        a8 = PlayerPrefs.GetInt("a8");
        a9 = PlayerPrefs.GetInt("a9");
        a10 = PlayerPrefs.GetInt("a10");
        a11 = PlayerPrefs.GetInt("a11");
        a12 = PlayerPrefs.GetInt("a12");
        a13 = PlayerPrefs.GetInt("a13");
        a14 = PlayerPrefs.GetInt("a14");
        a15 = PlayerPrefs.GetInt("a15");
        a16 = PlayerPrefs.GetInt("a16");
        a17 = PlayerPrefs.GetInt("a17");
        a18 = PlayerPrefs.GetInt("a18");
        a19 = PlayerPrefs.GetInt("a19");
        a20 = PlayerPrefs.GetInt("a20");
        a21 = PlayerPrefs.GetInt("a21");
        a22 = PlayerPrefs.GetInt("a22");
        scorevalue = PlayerPrefs.GetInt("scorevalue");

        username = PlayerPrefs.GetString("username");
    }

    public void upload(int stage,int solutionCount,int score)
    {
       /* Access.updateScore(username,score);
        if (solutionCount == 1)
            Access.insertSolutionCount(username, stage, solutionCount);
        else
            Access.updateSolutionCount(username, stage, solutionCount);*/
    }

    public void Stage1()
    {
        PlayerPrefs.SetInt("aa1", a1+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+10);
        PlayerPrefs.Save();
        upload(1,a1+1,scorevalue+10);
    }
    public void Stage2()
    {
        PlayerPrefs.SetInt("a2", a2+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+20);
        PlayerPrefs.Save();
        upload(2, a2+1, scorevalue+20);
    }
    public void Stage3()
    {
        PlayerPrefs.SetInt("a3", a3+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+30);
        PlayerPrefs.Save();
        upload(3, a3+1, scorevalue+30);
    }
    public void Stage4()
    {
        PlayerPrefs.SetInt("a4", a4+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+40);
        PlayerPrefs.Save();
        upload(4, a4+1, scorevalue+40);
    }
    public void Stage5()
    {
        PlayerPrefs.SetInt("a5", a5+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+50);
        PlayerPrefs.Save();
        upload(5, a5+1, scorevalue+50);
    }
    public void Stage6()
    {
        PlayerPrefs.SetInt("a6", a6+1);
        PlayerPrefs.SetInt("scorevalue", scorevalue+50);
        PlayerPrefs.Save();
        upload(6, a6 + 1, scorevalue + 50);
    }
    public void Stage7()
    {
        PlayerPrefs.SetInt("a7", a7 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 50);
        PlayerPrefs.Save();
        upload(7, a7 + 1, scorevalue + 50);
    }
    public void Stage8()
    {
        PlayerPrefs.SetInt("a8", a8 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 100);
        PlayerPrefs.Save();
        upload(8, a8 + 1, scorevalue + 100);
    }
    public void Stage9()
    {
        PlayerPrefs.SetInt("a9", a9 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue +200);
        PlayerPrefs.Save();
        upload(9, a9 + 1, scorevalue + 200);
    }
    public void Stage10()
    {
        PlayerPrefs.SetInt("a10", a10 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 300);
        PlayerPrefs.Save();
        upload(10, a10 + 1, scorevalue + 300);
    }
    public void Stage11()
    {
        PlayerPrefs.SetInt("a11", a11 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 400);
        PlayerPrefs.Save();
        upload(11, a11 + 1, scorevalue + 400);
    }
    public void Stage12()
    {
        PlayerPrefs.SetInt("a12", a12 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 500);
        PlayerPrefs.Save();
        upload(12, a12 + 1, scorevalue + 500);
    }
    public void Stage13()
    {
        PlayerPrefs.SetInt("a13", a13 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 600);
        PlayerPrefs.Save();
        upload(13, a13 + 1, scorevalue + 600);
    }
    public void Stage14()
    {
        PlayerPrefs.SetInt("a14", a14 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 700);
        PlayerPrefs.Save();
        upload(14, a14 + 1, scorevalue + 700);
    }
    public void Stage15()
    {
        PlayerPrefs.SetInt("a15", a15 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 800);
        PlayerPrefs.Save();
        upload(15, a15 + 1, scorevalue + 800);
    }
    public void Stage16()
    {
        PlayerPrefs.SetInt("a16", a16 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 900);
        PlayerPrefs.Save();
        upload(16, a16 + 1, scorevalue + 900);
    }
    public void Stage17()
    {
        PlayerPrefs.SetInt("a17", a17 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1000);
        PlayerPrefs.Save();
        upload(17, a17 + 1, scorevalue + 1000);
    }
    public void Stage18()
    {
        PlayerPrefs.SetInt("a18", a18 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1100);
        PlayerPrefs.Save();
        upload(18, a18 + 1, scorevalue + 1100);
    }
    public void Stage19()
    {
        PlayerPrefs.SetInt("a19", a19 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1200);
        PlayerPrefs.Save();
        upload(19, a19 + 1, scorevalue + 1200);
    }
    public void Stage20()
    {
        PlayerPrefs.SetInt("a20", a20 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1300);
        PlayerPrefs.Save();
        upload(20, a20 + 1, scorevalue + 1300);
    }
    public void Stage21()
    {
        PlayerPrefs.SetInt("a21", a21 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1400);
        PlayerPrefs.Save();
        upload(21, a21 + 1, scorevalue + 1400);
    }
    public void Stage22()
    {
        PlayerPrefs.SetInt("a22", a22 + 1);
        PlayerPrefs.SetInt("scorevalue", scorevalue + 1500);
        PlayerPrefs.Save();
        upload(22, a22 + 1, scorevalue + 1500);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}