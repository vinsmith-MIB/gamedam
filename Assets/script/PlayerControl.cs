using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;
    private Camera playerCamera;

    // Kecepatan karakter
    public float speed = 5.0f;
    public float raycastDistance = 0.1f;
    public LayerMask wallLayer; // Layer tembok

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        playerCamera = Camera.main;
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

        // Mengubah vektor pergerakan ke dalam koordinat dunia
        moveDirection = transform.TransformDirection(moveDirection);

        // Deteksi tabrakan dengan tembok
        RaycastHit hit;
        if (Physics.Raycast(transform.position, moveDirection, out hit, raycastDistance, wallLayer))
        {
            // Karakter menabrak tembok, hentikan pergerakan
            moveDirection = Vector3.zero;

            // Atur sudut pandangan (field of view) kamera ke sudut yang lebih kecil
            playerCamera.fieldOfView = 60f; // Ganti dengan sudut yang sesuai dengan kebutuhan
        }
        else
        {
            // Jika karakter tidak menempel tembok, atur sudut pandangan kembali ke sudut normal
            playerCamera.fieldOfView = 90f; // Ganti dengan sudut yang sesuai dengan kebutuhan
        }

        // Gerakkan karakter
        controller.Move(moveDirection * speed * Time.deltaTime);

        // Rotasi karakter
        transform.Rotate(new Vector3(0, mouseX, 0));

        // Animasi
        if (vertical != 0 || horizontal != 0)
        {
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
    }
}