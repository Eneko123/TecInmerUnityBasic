using UnityEngine;

public class Jerarquia : MonoBehaviour
{
    public GameObject goPadre;
    private GameObject goHijo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // goHijo.transform.SetParent(goPadre.transform); Tambien da putos errores de los cojones
        // goHijo.transform.parent = goPadre.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) { Debug.Log("Numero de hijos: " + goPadre.transform.childCount); }
        if (Input.GetKeyDown(KeyCode.B)) { Debug.Log("Numbre del primer hijo: " + goPadre.transform.GetChild(0).gameObject.name); }
    }
}
