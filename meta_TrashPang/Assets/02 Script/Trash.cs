using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour, IItem
{
    private Rigidbody rigid;

    void Awake()
    { 
        rigid = GetComponent<Rigidbody>(); 
    }
    public virtual void OnGoing(float power)
    {
        Debug.Log("on going");
        rigid.velocity = Vector3.zero;
        rigid.AddForce(transform.up*power);
        rigid.AddForce(transform.forward * power);
    }
}
