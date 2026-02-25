using UnityEngine;

public class MovimientoFoco : MonoBehaviour
{
    public Transform flecha;
    public Light foco;
    public bool luzEncendida = true;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(flecha);
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (luzEncendida)
            {
                foco.intensity = 0;
                luzEncendida = false;
            }
            else
            {
                foco.intensity = 10000;
                luzEncendida = true;
            }
        }
    }
}
