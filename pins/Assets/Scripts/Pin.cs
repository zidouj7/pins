using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pin : MonoBehaviour {

    private bool isPinned = false;



    public float speed = 20f;
    public Rigidbody2D rb;


	// Use this for initialization
	void Start () {



    }
	
	// Update is called once per frame
	void Update () {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

        }
        if(Score.PinCount == 0)
        {
            FindObjectOfType<GameManager>().EndGame();


        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            isPinned = true;

            Score.PinCount--;

            transform.SetParent(col.transform);

        }else if(col.tag == "Pin" && !isPinned){

            GameManager.adCounter++;


            FindObjectOfType<GameManager>().EndGame();

        }else if(col.tag == "Barrier" && !isPinned)
        {
            GameManager.adCounter++;

            isPinned = true;



            Score.PinCount++;

            transform.SetParent(col.transform);

        }
    }

}

            