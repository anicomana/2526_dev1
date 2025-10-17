using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public List<Camera> cameras;

    private int currentCamera;

    void Start()
    {
        foreach (Camera camera in cameras)
            camera.enabled = false;

        cameras[0].enabled = true;
        currentCamera = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)== true)
        {
            currentCamera.enabled = false;

            currentCamera = (currentCamera + 1) % 2;
        }
}
