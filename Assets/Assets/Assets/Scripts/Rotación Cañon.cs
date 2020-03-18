using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaciónCañon : MonoBehaviour
{

    private Touch touch;
    private Vector3 touchPosition;
    private Quaternion translateY;
    private float translateSpeedModifier = 0.1f;
    private float xMin = -1.0f, xMax = 1.0f;
    //


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {

                translateY = Quaternion.Euler(-touch.deltaPosition.y * translateSpeedModifier, 0f, 0f);


                transform.position = translateY * transform.position;
            }
           
        }
    }

}
