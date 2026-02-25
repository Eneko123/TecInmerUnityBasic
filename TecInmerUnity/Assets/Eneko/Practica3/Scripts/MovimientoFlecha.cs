using UnityEngine;

public class MovimientoFlecha : MonoBehaviour
{
    private int velocidad = 15;
    private int velocidadRotacion = 80;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * velocidad);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(Vector3.up * Time.deltaTime * velocidadRotacion);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Rotate(Vector3.down * Time.deltaTime * velocidadRotacion);
        }
    }
}
