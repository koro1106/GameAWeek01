using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // プレイヤーのTransform
    public float speed = 3f;

    private bool hasPassed = false; // 通過したか
    private float triggerHeightOffset = 0.5f; // 「飛び越えた」とする高さ
    private float lastPlayerX;

    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private CountdownTimer countdownTimer;
    [SerializeField] private PlayerCtrl playerCtrl;
    void Start()
    {
        lastPlayerX = player.position.x;
    }

    void Update()
    {
        if (!playerCtrl.isDead && countdownTimer.isStart)
        {
            // 死んでいないなら移動する
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        // 飛び越え判定（敵がプレイヤーを通り過ぎたとき）
        if (!hasPassed)
        {
            float playerY = player.position.y;
            float enemyY = transform.position.y;
            float enemyX = transform.position.x;
            float playerX = player.position.x;

            bool isAbove = playerY > (enemyY + triggerHeightOffset);
            bool enemyPassedPlayer = enemyX < playerX;

            if (isAbove && enemyPassedPlayer)
            {
                scoreManager.AddScore(10);
                hasPassed = true;
            }
        }
    }
}
