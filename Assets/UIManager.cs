using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtContraseña;
    public TMP_InputField inputClave;
    string contraseñaIngresada;
    string clave;

    // Start is called before the first frame update
    void Start()
    {
        txtContraseña.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void Saludar()
    {
        //obtener el nombre del inputfield

        contraseñaIngresada = inputClave.text;

        //concatenar el nombre con un saludo

        clave = "Hola " + contraseñaIngresada + "!";

        //mostrar el saludo en txtSaludo

        txtContraseña.text = clave;
    }
}
