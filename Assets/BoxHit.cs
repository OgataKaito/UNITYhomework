using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHit : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        ScoreManager.instance.AddScore(1);
        Destroy(this.gameObject);
        Debug.Log("“–‚½‚Á‚½");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
