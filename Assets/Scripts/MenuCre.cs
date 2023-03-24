using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCre : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Creditos;

    public GameObject Cuadrado;
    public GameObject Triangulo;
    public GameObject Rectangulo;

    // Start is called before the first frame update
    public void MenuFun()
    {
        Menu.SetActive(true);
        Creditos.SetActive(false);
    }

    // Update is called once per frame
    public void CreditosFun()
    {
        Menu.SetActive(false);
        Creditos.SetActive(true);
    }

public void CuadFun()
    {
        Cuadrado.SetActive(true);
	Triangulo.SetActive(false);
	Rectangulo.SetActive(false);
	Menu.SetActive(false);
        Creditos.SetActive(false);
    }
public void TriangFun()
    {
        Triangulo.SetActive(true);
        Rectangulo.SetActive(false);
        Cuadrado.SetActive(false);
	Menu.SetActive(false);
        Creditos.SetActive(false);
    }
public void RectanFun()
    {
        Rectangulo.SetActive(true);
        Triangulo.SetActive(false);
        Cuadrado.SetActive(false);
	Menu.SetActive(false);
        Creditos.SetActive(false);
    }
}
