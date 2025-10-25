using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float totalScore = 0;// 合計スコア
    public TextMeshProUGUI scoreText;
    public void AddScore(float score)
    {
        totalScore += score;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if(scoreText != null)
        {
            scoreText.text = "スコア：" + totalScore.ToString();
        }
    }

    public void ResetScore()
    {
        totalScore = 0;
        UpdateScoreText();
    }

}
