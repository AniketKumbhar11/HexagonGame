using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour {
    public GameObject PausePanel;
    public float Spwanrate = 1;
    public float NexrTimeToSpwan = 0f;
    int i = 50;
    public GameObject camera;
    public GameObject gameoverPanel;
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime*30);
        //if (Time.time >= NexrTimeToSpwan)
        //{
        //    camera.GetComponent<Camera>().backgroundColor = new Color(Random.Range(0f,255f), Random.Range(0f, 255f), Random.Range(0f, 255f));

        //    NexrTimeToSpwan = (Time.time + 1f) / Spwanrate;
        //    i++;
        //}
    }
    public void Pauseclick()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }
    public void ResumeClick()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    public void ExitClick()
    {
        gameoverPanel.SetActive(false);
        PausePanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void RestartClick()
    {
        Time.timeScale = 1;
        gameoverPanel.SetActive(false);
        PausePanel.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
