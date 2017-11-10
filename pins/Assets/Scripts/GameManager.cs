using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private bool gameHasEnded = false;
    public string level;
    public Rotator rotator;
    public Spawner spawner;

    public static int adCounter = 0;

    public Animator animator;


    public void Start()
    {
        Debug.Log(adCounter);

    }
    public void Update()
    {
        if (adCounter == 4)
        {

            Advertisement.Show();

            if (adCounter >= 4)
            {
                adCounter = 0;
            }
        }
    }

    // Use this for initialization
    public void EndGame () {

        if (gameHasEnded)
        {
            return;
        }

        if (Score.PinCount == 0)
        {
            animator.SetTrigger("WinGame");
            rotator.enabled = false;
            spawner.enabled = false;

            Level.levelnum++;
   
            
        }
        else
        {
            animator.SetTrigger("EndGame");

        }


        rotator.enabled = false;
        spawner.enabled = false;

        gameHasEnded = true;
        Debug.Log("End");
	}
	
	// Update is called once per frame
	public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(level);
    }

}
