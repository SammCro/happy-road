using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameB : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgain()
    { 
        SceneManager.LoadScene(2);
    }

    public void MainMenuR()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetScore()
    {
        TakeBunny.score = 0;
    }
}
