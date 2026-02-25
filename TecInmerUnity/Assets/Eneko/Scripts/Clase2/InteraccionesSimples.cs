using UnityEngine;

public class InteraccionesSimples : MonoBehaviour
{
    public PropiedadesJugador player;
    public GameObject hijo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Valores").GetComponent<PropiedadesJugador>();
        hijo = GameObject.Find("Cube");
        // player = GameObject.FindWithTag("Euneiz").GetComponent<PropiedadesJugador>();
        // player = GameObject.FindGameObjectWithTag("Euneiz").GetComponent<PropiedadesJugador>();
        // Averiguar porque no funciona con el tag, aunque el objeto tenga el tag correcto asignado.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up")) { Debug.Log("tecla up activada"); }
        else if (Input.GetKeyDown("down")) { Debug.Log("tecla down activada"); }
        else if (Input.GetKeyUp(KeyCode.K)) { Debug.Log("tecla k activada"); }
        else if (Input.GetKeyUp(KeyCode.N)) { Debug.Log("Nombre: " + player.nombre + " Pasword: " + player.pasword); }
        else if (Input.GetKeyUp(KeyCode.G)) { 
            hijo.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Cambio color"); }
    }
}
