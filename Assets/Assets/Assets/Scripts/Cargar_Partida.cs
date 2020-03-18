using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cargar_Partida : MonoBehaviour
{
    public static bool Cargando;
    public Button b;
    

    void Start()
    {

        b.interactable = PlayerPrefs.GetInt("scoreText") == null;
        
    }


    public void Cargar()
    {
        // PlayerPrefs.GetInt nos devuelven el valor que este dentro de
        //de las comillas, solo podremos guardar enteros, float y string
            Application.LoadLevel(1);
            Cargando = true;

    }
    public void NoCargar()
    {
        Cargando = false;
        Application.LoadLevel(1);
    }
   
}
