using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 1;
    public Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(dir * _speed * Time.deltaTime);

        _rb.velocity = dir * _speed;
        if (Input.GetKeyDown(KeyCode.W)) transform.position += Vector3.forward;
    }
}
