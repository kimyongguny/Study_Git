using UnityEngine;

public class AutoJumpOnGround : MonoBehaviour
{
    public float jumpForce = 100f;           // ���� ��
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }
    // �ٴڿ� ��� ���� �ڵ� ����
    void OnCollisionEnter(Collision collision)
    {
        // ������ ������Ʈ�� "Ground" ���̾��� ��츸
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            // �� �������� ���� ����
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
