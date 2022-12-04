using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(MouseLook))]
public class PlayerFPSController : MonoBehaviour
{
    public GameObject cam;
    public float walkSpeed = 5f;              // Walk speed
    public float hRotationSpeed = 100f;       // Player rotates along y axis
    public float vRotationSpeed = 80f;        // Cam rotates along x axis
    private CharacterMovement characterMovement;
    private MouseLook mouseLook;

    // Start is called before the first frame update
    private void Start()
    {
        // Oculta el ratón
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Busca al objeto de nombre "Body" y lo deshabilita en pantalla

        GameObject.Find("Body").gameObject.SetActive(false);

        characterMovement = GetComponent<CharacterMovement>();
        mouseLook = GetComponent<MouseLook>();

    }

    // Update is called once per frame
    private void Update()
    {
        movement();
        rotation();
    }
    private void movement()
    {
        // Movimiento
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        bool jumpInput = Input.GetButtonDown("Jump");
        bool dashInput = Input.GetButtonDown("Dash");

        characterMovement.moveCharacter(hMovement, vMovement, jumpInput, dashInput);
    }

    private void rotation()
    {
        float hRotationInput = Input.GetAxis("Mouse X");
        float vRotationInput = Input.GetAxis("Mouse Y");

        mouseLook.handleRotation(hRotationInput, vRotationInput);
    }
} 
