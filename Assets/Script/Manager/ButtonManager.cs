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
        scoreManager.ResetScore();// �X�R�A������
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);// �V�[���ēǂݍ���
    }
}
