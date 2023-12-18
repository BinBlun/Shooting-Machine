using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [Header("Properites")]
    [SerializeField] private float speed;

    private Rigidbody bulletRb;


    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.AddForce(BulletForce(), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 BulletForce()
    {
        return Vector3.forward * speed;
    }
}
