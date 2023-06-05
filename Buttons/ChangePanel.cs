using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Go()
    {
        Panel2.SetActive(true);
        Panel1.SetActive(false);
    }

    public void Back()
    {
        Panel1.SetActive(true);
        Panel2.SetActive(false);
    }

}
