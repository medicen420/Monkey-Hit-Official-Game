using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Tienda : MonoBehaviour
{
    public GameObject TiendaUI;
    //Esta lo que nos dice es cuando mostremos y cuando no, nuestra tienda en sí
    private bool show = false;
    void Start()
    {

    }
    void Update()
    {
        if (show)
        {
            TiendaUI.SetActive(true);
        }
        else
        {
            TiendaUI.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "banana 1(Clone)")
        {

            Debug.Log("menú abierto");

            show = !show;
        }

    }



}
