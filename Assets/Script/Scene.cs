using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void level1 ()
	{
        //SceneManager.LoadScene ("02-loading");
        Application.LoadLevel(1);
    }

	public void intro ()
	{
        //SceneManager.LoadScene ("02-loading");
        Application.LoadLevel(2);
	}
	public void home ()
	{
        Application.LoadLevel(3);
    }

    public void stage01()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(4);
    }
    public void stage02()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(5);
    }
    public void stage03()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(6);
    }
    public void stage04()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(7);
    }
    public void stage05()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(8);
    }
    public void stage06()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(9);
    }
    public void stage07()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(10);
    }


    public void stage8()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(11);
    }
    public void stage9()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(12);
    }
    public void stage10()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(13);
    }
    public void stage11()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(14);
    }
    public void stage12()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(15);
    }
    public void stage13()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(16);
    }
    public void stage14()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(17);
    }
    public void stage15()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(18);

    }
    public void stage16()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(19);

    }
    public void stage17()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(20);

    }
    public void stage18()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(21);

    }
    public void stage19()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(22);

    }
    public void stage20()
    {
       // SceneManager.LoadScene("02-loading");
        Application.LoadLevel(23);

    }
    public void stage21()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(24);

    }
    public void stage22()
    {
        //SceneManager.LoadScene("02-loading");
        Application.LoadLevel(25);

    }
    public void Leave()
    {
        Application.Quit();
    }
}



