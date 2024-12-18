using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDestroy : MonoBehaviour
{
    public GameObject ammoDestroy;  

    void OnCollisionEnter()
    {
        Destroy(ammoDestroy);
    }

}
