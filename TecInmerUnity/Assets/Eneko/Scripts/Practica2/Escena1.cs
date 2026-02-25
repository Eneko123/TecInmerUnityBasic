using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Escena1 : MonoBehaviour
{
    public GameObject esfera;
    public GameObject cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(cubo, new Vector3(2, 2, 2), Quaternion.identity);
    }
    
}
