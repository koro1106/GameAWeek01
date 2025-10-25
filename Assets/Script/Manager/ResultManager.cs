using TMPro;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultScoreText;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private GameObject result;
    [SerializeField] private GameObject score;

    public void ShowResult()
    {
        result.SetActive(true);
        score.SetActive(false);
        float finalScore = scoreManager.totalScore;
        resultScoreText.text = "スコア：" + finalScore.ToString();
    }
}