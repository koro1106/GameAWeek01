using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float totalScore = 0;// ���v�X�R�A
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
            scoreText.text = "�X�R�A�F" + totalScore.ToString();
        }
    }

    public void ResetScore()
    {
        totalScore = 0;
        UpdateScoreText();
    }

}
