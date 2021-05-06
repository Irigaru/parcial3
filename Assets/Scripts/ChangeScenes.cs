using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    public GameObject logIn;
    public GameObject Registro;
    public GameObject ok;
    public void Regristrarme()
    {
        logIn.SetActive(false);   
        ok.SetActive(false);
        Registro.SetActive(true);
    }
    public void Registrado()
    {
        logIn.SetActive(false);
        Registro.SetActive(false);
        ok.SetActive(true);
    }
    public void Ok()
    {
        ok.SetActive(false);
        logIn.SetActive(true);
        Registro.SetActive(false);     
    }
}
