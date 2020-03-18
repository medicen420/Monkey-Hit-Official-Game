using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_barril_die : MonoBehaviour
{
    public float puntos;
    public GameObject barril;
    //public GameObject monedilla;
    //public GameObject light_moneda_2;
    public GameObject boxcollider;
    
    // Start is called before the first frame update
    void Start()
    {
        //monedilla.SetActive(false);
        //light_moneda_2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "barril de madera_model")
        {
            //monedilla.SetActive(true);
            //light_moneda_2.SetActive(true);
           // Monedas.score += puntos;
            
            
            
        }


    }

}
