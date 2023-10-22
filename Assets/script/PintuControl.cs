using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isLocked = true; // Menandakan apakah pintu terkunci atau tidak
    public string requiredKey = "MissionKey"; // Nama kunci yang dibutuhkan untuk membuka pintu
    public GameObject doorModel; // Model pintu untuk animasi atau visualisasi

    private void Start()
    {
        // Inisialisasi pintu sesuai status awal
        UpdateDoorState();
    }

    public void UnlockDoor(string keyName)
    {
        if (isLocked && keyName == requiredKey)
        {
            isLocked = false;
            UpdateDoorState();
        }
    }

    private void UpdateDoorState()
    {
        // Tambahkan kode untuk mengubah visualisasi pintu atau animasinya
        if (doorModel != null)
        {
            // Misalnya, animasikan pintu terbuka
            Animator doorAnimator = doorModel.GetComponent<Animator>();
            if (doorAnimator != null)
            {
                doorAnimator.SetBool("IsOpen", !isLocked);
            }
        }
    }
}