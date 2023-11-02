using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxins : MonoBehaviour
{
    [SerializeField] GameObject _box;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Instantiate(_box, new Vector3(j * -5.0f, 1f,i * 1.0f), Quaternion.identity);
            }
        }
    }
}
