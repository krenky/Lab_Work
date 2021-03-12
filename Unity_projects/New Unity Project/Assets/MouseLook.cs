using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float SensitivityHor = 9.0f;
    public float SensitivityVer = 9.0f;

    public float MinVert = -45.0f;
    public float MaxVert = 45.0f;

    private float _rotationX = 0;

    public enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXandY;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if(body != null)
            body.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityHor, 0);
        }
        else
        {
            if(axes == RotationAxes.MouseY)
            {
                _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
                _rotationX = Mathf.Clamp(_rotationX, MinVert, MaxVert);
                float rotationY = transform.localEulerAngles.y;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            else
            {
                _rotationX -= Input.GetAxis("Mouse Y") * SensitivityVer;
                _rotationX = Mathf.Clamp(_rotationX, MinVert, MaxVert);

                float delta = Input.GetAxis("Mouse X") * SensitivityHor;
                float rotationY = transform.localEulerAngles.y + delta;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
        }
    }
}
