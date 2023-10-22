using UnityEngine;
using UnityEngine.SceneManagement;

public class navigateScene : MonoBehaviour
{
    public string namaScene;
    public void PindahKeSceneBaru(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}
