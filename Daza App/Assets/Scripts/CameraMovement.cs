using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Vector3 dragOrigin; 
    private Vector3 clickOrigin = Vector3.zero; 
    private Vector3 basePos = Vector3.zero;
    public bool bounds;
    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (clickOrigin == Vector3.zero)
            {
                clickOrigin = Input.mousePosition;
                basePos = transform.position;
            }
            dragOrigin = Input.mousePosition;
        }

        if (!Input.GetMouseButton(0))
        {
            clickOrigin = Vector3.zero;
            return;
        }

        transform.position = new Vector3(basePos.x + ((clickOrigin.x - dragOrigin.x) * .04f), basePos.y + ((clickOrigin.y - dragOrigin.y) * .04f), -10);

        if (bounds)
        {
            transform.position = new Vector3
                (
                    Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                    Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
                    Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z)
                );
        }
    }
}
