using UnityEngine;

public class Runtime : MonoBehaviour
{
    public GameObject mesa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // instancias las dos mesas y asignales una posicion
        // mesa.transform.position = new Vector3(5, 0, 0);
        Instantiate(mesa, new Vector3(5, 0, 0), Quaternion.identity);
        Instantiate(mesa, new Vector3(-5, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Constar cuantos objetos con el tag "Mesa" hay en la escena y mostrarlo por consola
            Debug.Log("Cantidad de mesas: " + GameObject.FindGameObjectsWithTag("Mesa").Length);

            // Acceder a cada prefab
            GameObject[] mesas = GameObject.FindGameObjectsWithTag("Mesa");
            for (int i = 0; i < mesas.Length; i++)
            {
                // Acceder a cada hijo de cada prefab
                for (int j = 0; j < mesas[i].transform.childCount; j++)
                {
                    // Cambiar el color de cada hijo a rojo
                    Renderer renderer = mesas[i].transform.GetChild(j).GetComponent<Renderer>();
                    renderer.material.color = Color.red;
                    // Mostrar su nombre y posicion por consola
                    Debug.Log("Hijo " + j + ": " + mesas[i].transform.GetChild(j).gameObject.name + mesas[i].transform.GetChild(j).gameObject.transform.position);
                }
            }
        }
    } 
}
