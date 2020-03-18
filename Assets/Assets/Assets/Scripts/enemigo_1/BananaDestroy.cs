using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    //Estas líneas de código me ayudan a que cuando colisionemos con un objeto llamado coco_model, mi proyectil banana será destruido
    //pero para que este sea destruido debemos de mandarlo llamar al script shot
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "coco_model")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "coco_model (1)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "barril de madera_model")
        {
            Destroy(gameObject);
        }

    }

    
}
