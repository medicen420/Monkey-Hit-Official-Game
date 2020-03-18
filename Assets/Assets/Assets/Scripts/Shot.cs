using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject banana;
    //public GameObject cañon;
    // Start is called before the first frame update
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            //VA A GENERAR EL RAYO DESDE UN PUNTO ESPECIFICO DE LA PANTALLA
            //quiero que el registro se genere al momento que tu presiones el boton 0 del mouse
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Debug.Log("Hola mundo");
            //

            //Esta lìnea de còdigo me permite generar esferas con un click 
            //GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            //Esta lìnea de còdigo me permite generar un objeto u modelo que yo quiera dentro de mis asstes 
            GameObject bullet = Instantiate(banana) as GameObject;
            //bullet.transform.position = transform.position + cañon.transform.forward * 1;
            Vector3 rotar_y = new Vector3(0, 90, 0);

            //para manejar físicas mandamos llamar a rigidbody
            bullet.AddComponent<Rigidbody>();
            //esta linea de codigo sirve para darle mayor fuerza de golpe o de masa a la esfera
            //pero en consecuencia debes aumentar la fuerza con la que se dispara :)
            bullet.GetComponent<Rigidbody>().mass = 3;
            //la siguiente linea de codigo quiere indicar que se agregara un componente nuevo de tipo collider para que 
            //la esfera choque contra los cubos
            bullet.AddComponent<BoxCollider>();



           //Mandamos llamar a este script para que se cumpla la condición de que cuando colisionemos con el coco
           //el proyectil se destruye
          
            bullet.AddComponent<BananaDestroy>();







            //
            //bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward*10000);



            //toma en cuenta la direccion del rayo dependiendo de donde doy click 
            bullet.GetComponent<Rigidbody>().AddForce(ray.direction * 10000);

        
            


        }
        
        
        
        
    }









}

