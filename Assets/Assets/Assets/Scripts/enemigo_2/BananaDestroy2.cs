using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaDestroy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Esta línea de código solo me esta indicando que cuando el objeto que contenga este script 
    //al momento de collisionar con un objeto llamado Mono_Model_Final_Mixamo@Jump Attack(Clone)
    //el proyectil o mi banana se destruira pero podre seguir generando bananas desde mi script shot
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "boxcollideranim")
        {
            Destroy(gameObject);
        }
    }
}
