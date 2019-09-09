using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour{

    public GameObject email;
    public GameObject passwd;
    public GameObject btnLogin;
     public GameObject logear;
     private string Email;
     private string Passwd;

    public GameObject pantallaDeCarga;
    public Slider slider;
    //public Text progreso;

    private void validarLogin(){
        if((Email == "User1@gmail.com") && (Passwd ==  "admin")){
            //StartCoroutine(CargaAsincronica(1));
            SceneManager.LoadScene(1);
        }
        else{
            print("usuario o contraseña incorrecta");
        }
    }

   /*  IEnumerator CargaAsincronica(int indice){
        AsyncOperation operacion = SceneManager.LoadSceneAsync(indice);
        pantallaDeCarga.SetActive(true);

        
        while(!operacion.isDone){
            float progreso = Mathf.Clamp01(operacion.progress / .9f);
            slider.value = progreso;

            yield return null;
        }
        
    }
*/
    void Update(){
        Email = email.GetComponent<InputField>().text;
        Passwd = passwd.GetComponent<InputField>().text;
        //btnLogin = logear.GetComponent<Button>();
        
        UnityEngine.UI.Button btn = btnLogin.GetComponent<Button>();
        
        btn.onClick.AddListener(validarLogin);
    }
}
