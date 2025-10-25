using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    public void ToTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void ToRePlayButton()
    {
        scoreManager.ResetScore();// スコア初期化
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);// シーン再読み込み
    }
}
