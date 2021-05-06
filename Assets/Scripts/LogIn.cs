using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour
{
    public Text us;
    public Text pas;
    public GameObject uno;
    public GameObject Ingresado_c;
    public GameObject error_l;

    public void hello()
    {
        if(Textos_Registro.user == us.text.ToString() && Textos_Registro.password == pas.text.ToString())
        {           
            Ingresado_c.SetActive(true);
            error_l.SetActive(false);
        }
        else if (Textos_Registro.user != us.text.ToString() && Textos_Registro.password != pas.text.ToString())
        {
            error_l.SetActive(true);
        }
    }

    public void ok()
    {
        uno.SetActive(true);
        Ingresado_c.SetActive(false);
    }
    public void ok2()
    {
        uno.SetActive(false);
    }

}
