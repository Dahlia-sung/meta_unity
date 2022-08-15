using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    public bool Rrotate { get; private set; }
    public bool Lrotate { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Rrotate = false;
        Lrotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rrotate = Input.GetKeyDown(KeyCode.D);
        Lrotate = Input.GetKeyDown(KeyCode.A);
        //Debug.Log("get key down : "+rotate);
    }
}
