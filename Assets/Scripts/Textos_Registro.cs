using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos_Registro : MonoBehaviour
{
    public Text Usuario;
    public Text Nombre;
    public Text Telefono;
    public Text Contraseña;

    public static string user;
    public static string password;

    public int a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;

    private void Start()
    {
        Deshabilitar();
    }
    void Update()
    {

        if (Usuario.text.Length >= 3)
        {
            a = 1;
        }
        if (Nombre.text.Length >= 4)
        {
            b = 1;
        }
        if (Telefono.text.Length == 8)
        {
            c = 1;
        }
        if (Contraseña.text.Length >= 6)
        {
            d = 1;
        }
        if(a == 1 && b == 1 && c == 1 && d == 1)
        {
            Habilitar();
        }

        user = Usuario.text.ToString();
        password = Contraseña.text.ToString();
    }

    public void Deshabilitar()
    {
        GetComponent<Button>().interactable = false;
    }
    public void Habilitar()
    {
        GetComponent<Button>().interactable = true;
    }
}
