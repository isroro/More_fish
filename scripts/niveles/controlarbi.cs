using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controlarbi : MonoBehaviour
{
    public int segs;
    public TMP_Text marcaSegs;

    public static int puntostotal;
    public int puntos;
    public TMP_Text marcaPuntos;
    // Start is called before the first frame update
    void Start()
    {
        segs = 91;
        InvokeRepeating("SumarSegs", 1, 1);
        marcaPuntos.text = puntos + "puntos";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SumarSegs()
    {
        if (segs == 0)
        {
            puntostotal += puntos;
            SceneManager.LoadScene("Menu");
        }
        if (segs > 0)
        {
            segs--;
            marcaSegs.text = segs + " segs";
        }
    }
    public void SumarPuntos()
    {
        puntos += 100;
        marcaPuntos.text = puntos + "pts";
    }
}
