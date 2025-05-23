using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed = 100f;

    void Update()
    {

        transform.position += transform.forward * BulletSpeed * Time.deltaTime;
    }
}
