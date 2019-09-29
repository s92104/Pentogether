using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour {
	public UISlider m_SliderLoading = null;
	public UILabel m_LabelLoading = null;
    public static int level = 1  ; 
	AsyncOperation m_AO = null;
    float displayProgress = 0;
    
   float toProgress = 0;
    // Use this for initialization
    void Start () {
		
		if (level != 0) 
		{

			StartCoroutine (LoadingScene());
		}

	}
	
	// Update is called once per frame
	void Update () {

		float displayProgress2 = displayProgress / 100;
		m_SliderLoading.value = displayProgress2;
		m_LabelLoading.text = "" + displayProgress;
	}

	IEnumerator LoadingScene()
	{
        m_AO = SceneManager.LoadSceneAsync(level);
        m_AO.allowSceneActivation = false;
		while (m_AO.progress < 0.9f) 
		{
            toProgress = (int)(m_AO.progress * 100);
            while (displayProgress < toProgress)
            {
                ++displayProgress;
               // SetLoadingPercentage(displayProgress);
                yield return new WaitForEndOfFrame();
            }
        }
        toProgress = 100;
        while (displayProgress < toProgress)
        {
            ++displayProgress;
            //SetLoadingPercentage (displayProgress);
            yield return new WaitForEndOfFrame();
        }
        m_AO.allowSceneActivation = true;
    }
}


