using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circulitocontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void VolverAlPuntoInicial()
    {
        // dejar de seguir a nadie (soy libre)
        transform.SetParent(null);
        // volver a escondeme (en el centro, debajo del suelo)
        transform.position = new Vector3(0, -3, 0);
    }

}

