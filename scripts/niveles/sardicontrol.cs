using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sardicontrol : MonoBehaviour
{
    public tienepez mipez;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseUpAsButton()
    {
        GameObject circulito = GameObject.Find("circulo");
        Debug.Log("Pez");

        if (circulito.transform.parent != null)
        {
            GameObject pingui = circulito.transform.parent.gameObject;
            NavMeshAgent nav = pingui.GetComponent<NavMeshAgent>();
            nav.destination = gameObject.transform.position;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pingu"))
        {
            Debug.Log("detectado");
            pinguicontrol pingu = collision.gameObject.GetComponent<pinguicontrol>();
            if (pingu.tienepez==tienepez.sinpez) {
                pingu.cambiar(mipez);
                gameObject.SetActive(false);
            }
        }
    }
}
