using UnityEngine;
using UnityEngine.SceneManagement;

public class Transformando : MonoBehaviour
{
    public int velocidad;
    public int velocidadRotacion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * velocidadRotacion);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * velocidadRotacion);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * velocidadRotacion);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * velocidadRotacion);
        }
    }

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        // SceneManager.LoadScene("Scena vacia");
    }

    private void OnMouseUp() {
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }

    private void OnMouseExit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
