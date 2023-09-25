using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pinguicontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public tienepez tienepez;
    public GameObject pez;
    public InputAction cerrar;
    // Start is called before the first frame update
    void Start()
    {
        cerrar.Enable();
        esconder();
        tienepez = tienepez.sinpez;
    }

    // Update is called once per frame
    void Update()
    {
        if (cerrar.triggered)
        {
            Debug.Log("funciono");
            Application.Quit();
        }
    }
    public void esconder()
    {
        pez.SetActive(false);
    }
    public void cambiar(tienepez nuevopez)
    {
        tienepez = nuevopez;
        esconder();
        switch (tienepez)
        {
            case tienepez.sinpez:
                break;
            case tienepez.conpez:
                pez.SetActive(true);
                break;
            default:
                break;
        }
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("Pin");
        GameObject circulito = GameObject.Find("circulo");
        circulito.transform.position = gameObject.transform.position;
        circulito.transform.SetParent(gameObject.transform);
    }
}
