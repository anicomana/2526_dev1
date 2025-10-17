using UnityEngine;

public class OncomingCars : MonoBehaviour
{

    public float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
