using UnityEngine;

public class Booster : MonoBehaviour
{

    private Rigidbody myRigidbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            myRigidbody.AddForce(Vector3.back * 50f);
        }
    }
}

