using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlayer : MonoBehaviour
{
    public GameObject panelSoal; // Pastikan Anda telah menghubungkan panel soal melalui Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("soal"))
        {
            Debug.Log("Tampilkan Soal");
            // Di sini Anda dapat menampilkan panel soal atau mengaktifkannya
            // panelSoal.SetActive(true);
        }
    }
}