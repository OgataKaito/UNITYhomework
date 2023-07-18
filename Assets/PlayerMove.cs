using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rb;
    bool _isGoal = false;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_isGoal == false)
        {
            Vector3 dir = new Vector3(-20f, 0, 0);
            dir.y = _rb.velocity.y;
            _rb.velocity = dir;
        }
        else
        {
            _rb.velocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            _isGoal = true;
        }
    }
}
