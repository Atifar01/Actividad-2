using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFPSController : MonoBehaviour
{
    public GameObject cam;
    public float walkSpeed = 5f;              // Walk speed
    public float hRotationSpeed = 100f;       // Player rotates along y axis
    public float vRotationSpeed = 80f;        // Cam rotates along x axis
    
    // Start is called before the first frame update
    void Start()
    {
        // Oculta el ratón
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        GameObject.Find("Body").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    private void movement()
    {
        // Movimiento
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward;
        transform.Translate(movementDirection * (walkSpeed * Time.deltaTime));

        // Rotación
        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
        float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;

        transform.Rotate(0f, hPlayerRotation, 0f);
        cam.transform.Rotate(-vCamRotation, 0f, 0f);
    }
}
