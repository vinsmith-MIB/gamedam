using UnityEngine;
using UnityEngine.UI;


public class isFalse : MonoBehaviour
{
    public GameObject[] isfalsepanel;

    public void isnotactive()
    {
        // Menonaktifkan semua elemen dalam array
        for (int i = 0; i < isfalsepanel.Length; i++)
        {
            isfalsepanel[i].SetActive(false);
        }
    }
}
