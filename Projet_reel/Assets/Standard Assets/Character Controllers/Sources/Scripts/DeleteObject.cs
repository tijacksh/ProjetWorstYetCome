using UnityEngine;
using System.Collections;

public class DeleteObject : MonoBehaviour
{

    void Start()
    {
        if (Input.GetButton("Fire1"))
            Destroy(transform.gameObject, 5);
    }

}