using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouse : MonoBehaviour
{

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;




    GameObject Player;

    // Use this for initialization
    void Start()
    {
        Player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {


       



    }
}
