using UnityEngine;

public class AutoJumpOnGround : MonoBehaviour
{
    public float jumpForce = 100f;           // 점프 힘
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    // 바닥에 닿는 순간 자동 점프
    void OnCollisionEnter(Collision collision)
    {
        // 접촉한 오브젝트가 "Ground" 레이어일 경우만
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            // 위 방향으로 힘을 가함
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    void Move()
    {
        float Speed = 5f;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, 0, z);

        transform.Translate(move * Speed * Time.deltaTime);
    }
}
