using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody RB_player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB_player = GetComponent<Rigidbody>();
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    void Move()
    {
        float Speed = 0.5f;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, 0, z);


        RB_player.AddForce(Move * Speed, ForceMode.Impulse);
    }
    void Jump()
    {
        float JumpForce = 5f;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB_player.AddForce(Vector3.up * JumpForce ,ForceMode.Impulse);
            
        }
    }
    /*public float moveSpeed = 5f;
     *float h = Input.GetAxis("Horizontal");
     *float v = Input.GetAxis("vertical");
     *
     *vector3 dir = new Vector3(h,0,v);
     *Debug.Log($"현재 입력 : {dir}");
     *
     *transform.position += dir * moveSpeed * Time.deltaTime;
     */
}
