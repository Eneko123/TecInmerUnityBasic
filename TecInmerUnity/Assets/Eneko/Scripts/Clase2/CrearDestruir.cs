using UnityEngine;

public class CrearDestruir : MonoBehaviour
{
    public GameObject miPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject miCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            miCubo.transform.position = new Vector3(2, 2, 2);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(miPrefab);
        }

    }
}
