using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBanana2 : MonoBehaviour
{
    
    Shot sh;
    public GameObject monomonkey;
    public float puntos;





    // Start is called before the first frame update
    void Start()
    {

        sh = GetComponent<Shot>();
        monomonkey = GameObject.FindGameObjectWithTag("monkey");


    }

    // Update is called once per frame
    void Update()
    {



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "banana(Clone)")
        {
            //En esta líena de código metimos este comentario con el fin de saber si se esta cumpliendo 
            //la condición if de collision del objeto "banana" vs "enemigo"
            Debug.Log("me rosas");

            //Esta línea de código permite que al momento de collisonar la "banana" vs el "enemigo"
            //el "enemigo será destruido 

            Destroy(monomonkey);
            //No es necesario indicar que tambien se destruya el gameobject "boxcollider" ya que 
            //si se manda a destruir al padre que contiene el gameobject en este caso todo se destruye
            //Destroy(gameObject);



            Score.score += puntos;


        }

    }
}
