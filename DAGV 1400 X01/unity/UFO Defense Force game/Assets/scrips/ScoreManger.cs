using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.PlayerLoop;

public class ScoreManger : MonoBehaviour
{
   public int score; // keeps our score

   public TextMeshProUGUI scoreText;  // visuals text

   public void IncreaseScore(int amount)
   {
        score += amount;
        UpdateScoreText();
   }

   public void DecreaseScore(int amount)
   {
        score -= amount;
        UpdateScoreText();
   }

   public void UpdateScoreText()
   {
    scoreText.text = "Score; "+  score;

   }
}
