using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    public bool rotate { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        rotate = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotate = Input.GetKeyDown(KeyCode.Space);
        Debug.Log("get key down : "+rotate);
    }
}
