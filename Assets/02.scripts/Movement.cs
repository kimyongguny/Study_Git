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
        float Speed = 5f;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, 0, z);


        this.transform.Translate(Move * Speed * Time.deltaTime);
    }
    void Jump()
    {
        float JumpForce = 5f;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB_player.AddForce(Vector3.up * JumpForce ,ForceMode.Impulse);
            
        }
    }
}
