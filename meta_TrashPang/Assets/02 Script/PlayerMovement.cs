using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float yAngle = 90f;
    private PlayerInput input;
    private Trash trash;
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        trash = GameObject.FindObjectOfType<Trash>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {

        if (input != null)
        {
            if(input.Rrotate)
            {
                transform.Rotate(Vector3.up * yAngle);
                trash.transform.Rotate(Vector3.up * yAngle); // 시점 회전시 생성된 쓰레기도 방향회전

            }

            if(input.Lrotate)
            {
                transform.Rotate(Vector3.up * yAngle * -1);
                trash.transform.Rotate(Vector3.up * yAngle*-1); // 시점 회전시 생성된 쓰레기도 방향회전
            }

        }

    }
}
