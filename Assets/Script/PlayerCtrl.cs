using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
[System.Obsolete]

public class PlayerCtrl : MonoBehaviour
{
    public float jumpForce = 5f;            // ジャンプの強さ
    private Rigidbody2D rb;
    private bool isGrounded;
    public  bool isDead;
    public Animator animator;
    [SerializeField] private CountdownTimer timer;
    [SerializeField] private ResultManager resultManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (timer.isStart && isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);  // 上方向に速度を与える
            animator.SetBool("isJump", true);
        }
        if (isDead)
        {
            animator.SetBool("isDead", true);
            resultManager.ShowResult();
        }
    }

    // 接地判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            animator.SetBool("isJump", false);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            isDead = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag ==("Ground"))
        {
            isGrounded = false;
        }
    }
}
