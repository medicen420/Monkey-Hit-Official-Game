using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCañ : MonoBehaviour
{
    Vector3 Rotx;
    Vector3 Roty;
    public Touch touch;
    private Vector3 touchPosition;
    private Quaternion rotationY;
    public float rotateSpeedModifier = 0f;
    public float MaxY;
    public float MinY;
    //Para las variables de X utilizaremos las siguientes
    public float MaxX;
    public float MinX;
    private Quaternion rotationX;
    

    // Start is called before the first frame update
    void Start()
    {
        //rotationY = Quaternion.Euler(0f, 0, 0);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            touch = Input.GetTouch(0);
            
            
            if (touch.phase == TouchPhase.Moved)
            {
              

                //transform.localRotation = Quaternion.Euler(0, 0, 0);
                //rotationY = Quaternion.Euler(0f, -touch.deltaPosition.x * rotateSpeedModifier, 0f);
                rotationY.y = Mathf.Clamp(rotationY.y, MinY, MaxY);


                //tomara ahora el angulo del objeto con localRotation
                //antes con rotation tomaba en algulo pero global
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                transform.rotation = rotationY * transform.rotation;

               

            }
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    rotationY = Quaternion.Euler(0f, -touch.deltaPosition.y * rotateSpeedModifier, 0f);
                    rotationY.y = Mathf.Clamp(rotationY.y, MinY, MaxY);


                    //tomara ahora el angulo del objeto con localRotation
                    //antes con rotation tomaba en algulo pero global
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    transform.rotation = rotationY * transform.rotation;
                   /* rotationX = Quaternion.Euler(-touch.deltaPosition.y * rotateSpeedModifier, 0f, 0f);
                    rotationX.x = Mathf.Clamp(rotationX.x, MinX, MaxX);

                    transform.localRotation = Quaternion.Euler(0, 0, 0);

                    transform.rotation = rotationX * transform.rotation;*/
                }
            }
        }
    }
}
