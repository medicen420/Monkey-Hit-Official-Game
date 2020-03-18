using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Tener cuidado de las mayusculas puesto que me tomo 1 hora decifrar por que no respetaba la colision
    //que hago con el proyectil hacia la box, la razón era muy simple y no la había visto, estaba colocando OntriggerEnter y 
    //debería de ser con mayúsculas OnTriggerEnter
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "banana(Clone)")
        {
            Debug.Log("hay mamacita");
        }
    }
}
