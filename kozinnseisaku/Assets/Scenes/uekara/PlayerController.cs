using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private bool isGrounded;
    private Rigidbody2D rb;
    private bool gameOver = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!gameOver)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

            float horizontalInput = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
            rb.velocity = movement;

            if (isGrounded && Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("buttaiA"))
        {
            Debug.Log("Game Over (buttaiA touched)");
            GameOver();
        }
    }

    void GameOver()
    {
        // ゲームオーバー時にタイムスケールを0に設定してゲームを停止
        Time.timeScale = 0f;
        gameOver = true;

        // ここにゲームオーバー画面の表示や他の処理を追加
    }
}
