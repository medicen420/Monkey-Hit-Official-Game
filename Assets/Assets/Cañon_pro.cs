using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon_pro : MonoBehaviour
{
    public float RotaY;
    public float RotaX;


    public float velocidad;
    public GameObject CamVPlayer;
    //velocidad de rotación
    public float velRot = 180.0f;
    //vector para almacenar la rotación de la cámara
    Vector3 RotX;
    Vector3 Roty;
    Vector3 RotMx;
    //límites de la rotación

    float minRot = -80.0f;
    float maxRot = 80.0f;
    public float rx;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        RotX = transform.eulerAngles;
        RotMx = transform.eulerAngles;
        Roty = transform.eulerAngles;
        
    }

    // Update is called once per frame
    void Update()
    {
      
        RotaY = Input.GetAxis("Mouse X") * velocidad * Time.deltaTime;
        transform.Rotate(0, RotaY, 0);

        RotaX = Input.GetAxis("Mouse Y") * velocidad * Time.deltaTime;
        transform.Rotate(0, RotaX, 0);
    }
}
