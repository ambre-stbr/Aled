using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_movement : MonoBehaviour
{
    [SerializeField] 
    private float MouseHorizontal;

    // Update is called once per frame
    void Update()
    {
        float HorizontalSpeed = MouseHorizontal*Input.GetAxis("Mouse X");
        transform.Rotate(0, HorizontalSpeed, 0);

    }
}
