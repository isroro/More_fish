using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class iglucontrol : MonoBehaviour
{
    public tienepez mipez;
    public controlarbi arbi;
    // Start is called before the first frame update
    void Start()
    {
        arbi = GameObject.FindObjectOfType<controlarbi>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("pingu"))
        {
            pinguicontrol elpingu = collision.gameObject.GetComponent<pinguicontrol>();
            Debug.Log("se a detectado");
            if (elpingu.tienepez == mipez)
            {
                Debug.Log("se a ");
                arbi.SumarPuntos();
                elpingu.cambiar(tienepez.sinpez);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("iglu");
        GameObject circulito = GameObject.Find("circulo");

        if (circulito.transform.parent != null)
        {
            GameObject pingui = circulito.transform.parent.gameObject;
            NavMeshAgent nav = pingui.GetComponent<NavMeshAgent>();
            nav.destination = gameObject.transform.position;
        }
    }
}
