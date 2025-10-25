using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    private float limitTime = 3f; // 制限時間
    private float startDisplayTime = 1f; // スタートを表示する時間

    public bool isStart = false; //スタートしているか
    private bool countdownFinished = false; //カウントダウンが終了しているか
    private bool showStartText = false;
    void Update()
    {
        // カウントダウンが終わってないならカウント開始
        if(!countdownFinished)
        {
            limitTime -= Time.deltaTime;

            if (limitTime > 0)
            {
        　　　timeText.text = "  " + Mathf.CeilToInt(limitTime).ToString(); // 小数点以下切り捨て表示
            }
            else
            {
                // カウントダウン終了
                limitTime = 0;
                countdownFinished = true;
                showStartText = true;
                timeText.text = "スタート！";
            }
        }
       else if(showStartText)
        {
            // スタートを一定時間表示したら非表示に
            startDisplayTime -= Time.deltaTime;

            if (startDisplayTime <= 0f)
            {
                timeText.text = "";
                isStart = true;
                showStartText = false;
            }
        }
    }
}
