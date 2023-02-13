using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiviteAfterPos : MonoBehaviour
{
    public float bulletDeactivatePos;

    void Update()
    {

        if(transform.position.y > bulletDeactivatePos || transform.position.y < -bulletDeactivatePos)
        {
            gameObject.SetActive(false);
        }
        
    }
}
