using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_cañon : MonoBehaviour
{
    //public float maxAngulo = 45.0f; // Ángulo máximo de rotación
    //private Quaternion rotacionBase; // Rotación base
    //private Quaternion rotacionDeseada; // Rotación deseada

    private Touch touch;
    private Vector3 touchPosition;
    private Quaternion rotationX;
    private float rotateSpeedModifier = 0.1f;
    public float LimitMax = 90.0f;
    public float LimitMin = -60.0f;
    Vector3 LimitRotation;
    public GameObject cañon;
    Vector3 rotacionx;


    // Start is called before the first frame update
    void Start()
    {
        rotacionx = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
       
        //eulerangles tranforma valores en angulos
        transform.localEulerAngles = rotacionx;
        rotacionx.x-= Input.GetAxis("Mouse Y") * rotateSpeedModifier * Time.deltaTime;
        rotacionx.x = Mathf.Clamp(rotacionx.x, LimitMin, LimitMax);
        transform.localEulerAngles = rotacionx;


        /*if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationX = Quaternion.Euler(-touch.deltaPosition.x * rotateSpeedModifier, 0f, 0f);
                LimitRotation.x = Mathf.Clamp(LimitRotation.x, LimitMin, LimitMax);
                cañon.transform.localEulerAngles -= new Vector3(LimitRotation.x, 0, 0);

               // transform.rotation = rotationX * transform.rotation;
            }
           
        }*/
    }




}




