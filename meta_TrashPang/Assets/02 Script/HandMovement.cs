using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right*speed*Time.deltaTime,Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        IItem item = collision.collider.GetComponent<IItem>();
        if(item!=null)
        {
            item.OnGoing(300);
        }
    }
}
