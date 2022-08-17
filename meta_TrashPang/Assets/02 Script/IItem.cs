using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{
    void OnGoing(float power);
    void onGoal(GameObject collider);
}

