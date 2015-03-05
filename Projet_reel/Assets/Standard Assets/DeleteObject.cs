using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

    void Start()
    {
        if (Input.GetKeyDown("c"))
            Destroy(transform.gameObject);
    }

}