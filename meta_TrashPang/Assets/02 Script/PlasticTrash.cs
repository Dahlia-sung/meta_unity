using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticTrash : Trash
{   
    public override void onGoal(GameObject collider) // ��ü�� ���������� ���� ��
    {
        if (collider.tag=="Plastic") //�ùٸ� ���������� ���
        {
            result.text = "SUCCESS";
        }
        else // �߸��� ���������� ���
        {
            result.text = "FAIL";
        }
        base.onGoal(collider);
    }

}
