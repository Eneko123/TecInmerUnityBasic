using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    public GameObject objeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Soy el puto amo");
        objeto.transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
