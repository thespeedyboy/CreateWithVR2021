using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TVCanvascontrol : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public int score = 0;
    
    void Start()
    {
        UpdateScoreDisplay();
    }
   public void UpdateScoreDisplay()
    {
        scoreDisplay.text = $"score : {score}";
    }
    public void AddToScore()
    {
        score++;
        UpdateScoreDisplay();
    }
}
