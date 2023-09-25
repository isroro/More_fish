using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class menu : MonoBehaviour
{
    public TMP_Text marcadorPuntost;
    public Button botonNivel2;
    public Button botonNivel3;
    public InputAction cerrar;

    private void Start()
    {
        cerrar.Enable();
        marcadorPuntost.text = controlarbi.puntostotal + " puntos totales";
        if (controlarbi.puntostotal >= 700)
        {
            Debug.Log("ha llegado a 700 o más");
            botonNivel2.interactable = true;
        }
        if (controlarbi.puntostotal < 700)
        {
            botonNivel2.interactable = false;
        }
        if (controlarbi.puntostotal >= 1400)
        {
            Debug.Log("ha llegado a 700 o más");
            botonNivel3.interactable = true;
        }
        else
        {
            botonNivel3.interactable = false;
        }
    }
    private void Update()
    {
        if (cerrar.triggered)
        {
            Debug.Log("funciono");
            Application.Quit();
        }
    }

    public void IrAlNivel(int nivelDestino)
    {
        SceneManager.LoadScene("Nivel" + nivelDestino);
    }



    public void guardar()
    {
        PlayerPrefs.SetInt("puntosGuardados", controlarbi.puntostotal);
    }

    public void cargar()
    {
        controlarbi.puntostotal = PlayerPrefs.GetInt("puntosGuardados");
        Start();
    }

    public void borrar()
    {
        PlayerPrefs.DeleteAll();
        controlarbi.puntostotal = 0;
        Start();
    }
}
