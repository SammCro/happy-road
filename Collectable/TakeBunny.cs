using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeBunny : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ScoreText1;
    void OnTriggerEnter(Collider other)
    {
        AddBunny();
        this.gameObject.SetActive(false);
    }

    public void AddBunny()
    {
        score++;
        ScoreText.text = "Bunny: " + score.ToString();
        ScoreText1.text = "You Saved " + score.ToString() + " Bunnies";
    }
}
