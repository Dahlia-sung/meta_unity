using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTrash : Trash
{
    public override void onGoal(GameObject collider) // 물체가 골인지점에 들어갔을 때
    {
        if (collider.tag == "Paper") //올바른 골인지점일 경우
        {
            result.text = "SUCCESS";
        }
        else // 잘못된 골인지점일 경우
        {
            result.text = "FAIL";
        }
        base.onGoal(collider);
    }
}
