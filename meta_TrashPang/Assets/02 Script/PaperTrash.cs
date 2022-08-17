using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTrash : Trash
{
    public override void onGoal(GameObject collider) // ��ü�� ���������� ���� ��
    {
        if (collider.tag == "Paper") //�ùٸ� ���������� ���
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
