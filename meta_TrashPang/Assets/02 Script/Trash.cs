using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Trash : MonoBehaviour, IItem
{
    protected Rigidbody rigid;
    public TextMeshProUGUI result;

    void Awake()
    { 
        rigid = GetComponent<Rigidbody>();
        result.enabled = false;
    }

    //게임 오브젝트 날리기
    public void OnGoing(float power) 
    {
        Debug.Log("on going");
        rigid.velocity = Vector3.zero;
        rigid.AddForce(transform.up*power);
        rigid.AddForce(transform.forward * power);
    }

    public virtual void onGoal(GameObject collider)
    {
        result.enabled = true;
        Debug.Log("goal!");
    }
}
