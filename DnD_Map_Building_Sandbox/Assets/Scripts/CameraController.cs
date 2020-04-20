using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : NetworkBehaviour
{
    float zoom;
    public GameObject mCamera;
    Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        zoom = 6.0f;
        mainCam = mCamera.GetComponent<Camera>();
        mCamera.transform.position = new Vector3(0.0f, 10.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempVec = new Vector3();


        // Move Camera Up
        if (Input.GetKey(KeyCode.W))
        {
            tempVec.z += 0.01f;
        }

        // Move Camera Down
        if (Input.GetKey(KeyCode.S))
        {
            tempVec.z -= 0.01f;
        }

        // Move Camera Left
        if (Input.GetKey(KeyCode.A))
        {
            tempVec.x -= 0.01f;
        }

        // Move Camera Right
        if (Input.GetKey(KeyCode.D))
        {
            tempVec.x += 0.01f;
        }

        // Create a temporary zoom value and set it equal to zoom
        float tempZoom = zoom;

        // Use the Scroll Wheel to zoom in
        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            tempZoom -= 1.0f;
        }

        // Use the Scroll Wheel to zoom out
        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            tempZoom += 1.0f;
        }

        if (tempZoom >= 1.0f && tempZoom <= 6.0f)
        {
            zoom = tempZoom;
        }


        mainCam.orthographicSize = zoom;

        mCamera.transform.position += new Vector3(tempVec.x, 0.0f, tempVec.z);
    }
}
