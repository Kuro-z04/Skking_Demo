using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float torque = 1;
    [SerializeField] float changeSpeed = 30;
    [SerializeField] float normalSpeed = 20;
    public bool check = true;
    new Rigidbody2D rigidbody2D;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (check) {
            Rotation();
            SurfaceEffector2D();
        }
    }

    public void stopMove() {
        check = false;
    }

    void Rotation() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody2D.AddTorque(torque);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            rigidbody2D.AddTorque(-torque);
        }
    }

    void SurfaceEffector2D() {
        if (Input.GetKey(KeyCode.Space)) {
            surfaceEffector2D.speed = changeSpeed;
        }
        else {
            surfaceEffector2D.speed = normalSpeed;
        }
    }
}
