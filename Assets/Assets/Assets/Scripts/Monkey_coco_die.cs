using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_coco_die : MonoBehaviour
{
    public static int puntos = 1;
    public Animator anim_monkey;


    //public Animator moneda_conseguida;
    //Estas son las monedas que aparecen en todo el escenario 
    //cuando matas a un enemigo

    //public GameObject moneda;
    //public GameObject moneda2;

    //Aquí van colocadas las luces que alumbran la moneda 
    //de frente
    public GameObject luzmoneda;
    public BoxCollider bx;
    public BoxCollider box;
    
    

    // Start is called before the first frame update
    void Start()
    {

       

       //moneda.SetActive(false);
       //luzmoneda.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "coco_model")
        {
            //moneda.SetActive(true);
            anim_monkey.SetBool("Dead_1", true);
            //moneda_conseguida.Play("moneda_idle");
            
            //luzmoneda.SetActive(true);
            Destroy(bx);
            //Monedas.score += puntos;
            Monedas.score += puntos;
    
        }
        if (other.gameObject.name == "coco_model (2)")
        {
            anim_monkey.SetBool("Dead_2", true);
            //moneda_conseguida.Play("moneda_idle");
            //moneda.SetActive(true);
            //luzmoneda.SetActive(true);
            Destroy(box);
            //Monedas.score += puntos;
            Monedas.score += puntos;

        }






    }


}
