using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] private float forceJump;
    bool aux=true;
    float horizontal;
    float vertical;
    [SerializeField]  float speed;
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
       if(Input.GetKeyDown(KeyCode.Space) && aux==true)
        {
            _compRigidbody.AddForce(new Vector3(0f, forceJump, 0f), ForceMode.Impulse);
            aux = false;
        }

    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector3(horizontal*speed, _compRigidbody.velocity.y, vertical*speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            aux = true;
            
        }
    }



}
