using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; // �v���C���[��Transform
    public float speed = 3f;

    private bool hasPassed = false; // �ʉ߂�����
    private float triggerHeightOffset = 0.5f; // �u��щz�����v�Ƃ��鍂��
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
            // ����ł��Ȃ��Ȃ�ړ�����
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        // ��щz������i�G���v���C���[��ʂ�߂����Ƃ��j
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
