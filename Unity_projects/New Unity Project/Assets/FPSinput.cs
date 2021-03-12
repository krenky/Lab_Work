using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSinput : MonoBehaviour
{
    private CharacterController _charController;
    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    public float speed = 1.0f;
    public float gravity = -9.8f;

    // Update is called once per frame
    void Update()
    {

        float DeltaX = Input.GetAxis("Horizontal") * speed;
        float DeltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(DeltaX, 0, DeltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement.y = gravity;
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        //transform.Translate(DeltaX * Time.deltaTime, 0, DeltaZ * Time.deltaTime);
    }
}
