using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreandeThrower : MonoBehaviour
{
    [SerializeField] private float _throwForce = 40f;
    public GameObject GrenadePerfeb;
    
    public void Throw(bool enable)
    {
        if (enable != false)
        {
            GameObject greande = Instantiate(GrenadePerfeb, transform.position, transform.rotation);
            Rigidbody rigidbody = greande.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * _throwForce);
        }
    }
}
