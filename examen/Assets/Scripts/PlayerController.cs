using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] private float forceJump;

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
       if(Input.GetKeyDown(KeyCode.Space))
        {
            _compRigidbody.AddForce(new Vector3(0f, forceJump, 0f), ForceMode.Impulse);
        }

    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector3(horizontal*speed, _compRigidbody.velocity.y, vertical*speed);
        
    }




}
