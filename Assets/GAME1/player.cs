using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class player : MonoBehaviour {

    public float MoveSpeed = 600f;
    private float Movement;
    public GameObject GameOverPanel;
    public float score;
    public Text ScoreText;
    private bool Flag;
    private int scevalu = 20;
    public float ScrenWidh;
    public float GlobalSpwanRate = 5f;
      public float GlobalStrinkSpeed=1f;
    public static player objplayer = null;
    private void Awake()
    {
        objplayer = this;
    }



    void Start () {
        ScrenWidh = Screen.width;
        Time.timeScale = 1;
        ScoreText.text = "";
        GameOverPanel.SetActive(false);
        Flag = true;
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {





        Movement = Input.GetAxisRaw("Horizontal");
        //int i=0;
        //while (i<Input.touchCount)
        //{
        //    if (Input.GetTouch(i).position.x>ScrenWidh/2)
        //    {
        //        Movement = 1;
        //        BallMove(Movement);
        //    }
        //    if (Input.GetTouch(i).position.x < ScrenWidh / 2)
        //    {
        //        Movement = -1;
        //        BallMove(Movement);
        //    }
        //    ++i;
        //}


        if (true)
        {

            score += Time.deltaTime;
            ScoreText.text ="SCORE : "+ Mathf.Round(score).ToString();
            Debug.Log(Mathf.Round(score));
            //if (Mathf.Round(score)%20==0 /*&& GlobalSpwanRate >= 1f && GlobalStrinkSpeed <= 5f*/)
            //{
            //    GlobalSpwanRate -= 0.5f;
            //    GlobalStrinkSpeed += 0.5f;
         

            //}




        }
    }
    //private void BallMove( float Movement)
    //{
    //   transform.RotateAround(Vector3.zero, Vector3.forward , Movement * Time.deltaTime * -MoveSpeed);



    //}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, Movement * Time.deltaTime * -MoveSpeed);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Flag = false;
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
      GameOverPanel.transform.GetChild(1).GetComponent<Text>().text = ScoreText.text;
        


    }


}
