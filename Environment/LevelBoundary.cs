using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.5f, rightSide = 3.5f;
    public float internalLeft, internalRight;


    void Start()
    {
        
    }

    
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
