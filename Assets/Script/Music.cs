using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    public AudioSource audSource;
    public static float m_MySliderValue;
    // Use this for initialization
    private void Awake()
    {
 //DontDestroyOnLoad(this.gameObject);
    }
    void Start () {
        m_MySliderValue = 0.5f;
        audSource = gameObject.GetComponent<AudioSource>();
        audSource.Play();
    }
	// Update is called once per frame
	void Update () {
        audSource.volume = m_MySliderValue;
    }
    public void Msic_slider(float newValue)
    {
        // m_MySliderValue = slider.gameObject.GetComponent("Slider").value;
        m_MySliderValue = newValue;
    }
}
