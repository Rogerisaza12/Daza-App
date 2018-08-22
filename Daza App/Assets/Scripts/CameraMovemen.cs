using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemen : MonoBehaviour
{

    private Vector3 dragOrigin; 
    private Vector3 clickOrigin = Vector3.zero; 
    private Vector3 basePos = Vector3.zero; 

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
    }
}
