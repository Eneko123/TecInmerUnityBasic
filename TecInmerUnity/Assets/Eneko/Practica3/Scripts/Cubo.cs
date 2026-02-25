using UnityEngine;
using UnityEngine.SceneManagement;

public class Cubo : MonoBehaviour
{
    public GameObject esfera;
    private void OnMouseDown()
    {
        Instantiate(esfera, new Vector3(1, 1, 1), Quaternion.identity);
    }
}
