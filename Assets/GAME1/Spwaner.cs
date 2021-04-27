using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour {

    public GameObject HexagonPrefab;
    public float Spwanrate = 5;
    public float NexrTimeToSpwan = 0f;
   

    void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time>=NexrTimeToSpwan)
        {
            Spwanrate = player.objplayer.GlobalSpwanRate;
            Instantiate(HexagonPrefab, Vector3.zero, Quaternion.identity);

            NexrTimeToSpwan = (Time.time+ 1) / Spwanrate;
        }
	}
}
