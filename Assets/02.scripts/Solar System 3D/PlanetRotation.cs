using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f;
    public float revolutionSpeed = 100f;
    public bool isRevolution = false;
    void Update()
    {
        //자기자신이 회전하는 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if(isRevolution == true)
        { 
        transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }

    }
}
