using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagonscript : MonoBehaviour {
    public Rigidbody2D rb;
    public float StrinkSpeed = 1f;
  

    void Start () {
        StrinkSpeed = player.objplayer.GlobalStrinkSpeed;
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale -= Vector3.one * StrinkSpeed * Time.deltaTime;
        if (transform.localScale.x<=0.5f)

        {
            Destroy(gameObject);    
        }
	}
}
