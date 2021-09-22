using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    public GameObject cube;
    private int a = 10;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            cube.transform.Rotate(0, a, 0);
            a += 10;
        }
    }
}
