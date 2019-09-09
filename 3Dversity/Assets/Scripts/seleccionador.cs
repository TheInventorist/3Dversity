using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class seleccionador : MonoBehaviour
{
   public GameObject botonMenu;
   public GameObject botonVolver;
   public GameObject menuSeleccionadorCategorias;
   public GameObject botonCategoria1;
   public GameObject botonCategoria2;
   public GameObject cristal1;
   public GameObject cristal2;
    Vector3 fuera = new Vector3(30.0f,0,0);
    Vector3 enJuego = new Vector3(0,0,0); 
    
    void Start(){
        menuSeleccionadorCategorias.SetActive(false);
    }
    void Update()
    {

        UnityEngine.UI.Button BotonMenu = botonMenu.GetComponent<Button>();
        UnityEngine.UI.Button BotonVolver = botonVolver.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat1 = botonCategoria1.GetComponent<Button>();
        UnityEngine.UI.Button BotonCat2 = botonCategoria2.GetComponent<Button>();

        BotonMenu.onClick.AddListener(mostrarMenuCategorias);
        BotonVolver.onClick.AddListener(ocultarMenuCategorias);
        BotonCat1.onClick.AddListener(cambiarCristal1);
        BotonCat2.onClick.AddListener(cambiarCristal2);

        

    }
    public void cambiarCristal1(){
        //cristal2.transform.position.Set(30,30,30);
        //cristal1.transform.position.Set(0,0,0);
        cristal2.transform.position = fuera;
        cristal1.transform.position = enJuego;
        menuSeleccionadorCategorias.SetActive(false);

    }
    public void cambiarCristal2(){
        //cristal1.transform.position.Set(30,30,30);
        //cristal2.transform.position.Set(0,0,0);
        cristal2.transform.position = enJuego;
        cristal1.transform.position = fuera;
        menuSeleccionadorCategorias.SetActive(false);
    }

    private void mostrarMenuCategorias(){
        menuSeleccionadorCategorias.SetActive(true);
    }
    private void ocultarMenuCategorias(){
        menuSeleccionadorCategorias.SetActive(false);
    }
}
