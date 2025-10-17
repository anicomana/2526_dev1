using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject followObject;
    public Vector3 offset = new Vector3(0, 5, -15);

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

        if (followObject == null)
            {
            Debug.LogError("FollowPlayer: followObject is not assigned.");
        }
        else
            {
            Debug.Log("FollowPlayer: following " + followObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // LateUpdate is called once per frame after all Update functions have been called
    void LateUpdate()
    {
        transform.position = followObject.transform.position + offset;
    }
}
