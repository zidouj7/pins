using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    

    // Use this for initialization
    public void LoadStart()
    {
        SceneManager.LoadScene("Main");
    }


}
