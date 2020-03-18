using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    public GameObject cubito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //comportamientos 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cubo")
        {
            Destroy(cubito);
            Debug.Log("huevos");
        }
    }
}
