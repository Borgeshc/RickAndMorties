using UnityEngine;
using System.Collections;
using InControl;
public class Shoot : MonoBehaviour
{
    public GameObject barrel;
    public GameObject bullet;
    public float bulletSpeed;

    Animator anim;
    InputDevice inputDevice;
    RaycastHit hit;
    bool shooting;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        inputDevice = InputManager.ActiveDevice;
        if (inputDevice.RightTrigger.WasPressed)
        {
            if(!shooting && Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 1000))
            {
                shooting = true;
                Fire(hit.point);
            }
        }
    }

    void Fire(Vector3 aimPoint)
    {
        anim.SetTrigger("Shoot");
        GameObject clone = Instantiate(bullet, barrel.transform.position, transform.rotation) as GameObject;
        Rigidbody rb = clone.GetComponent<Rigidbody>();
        rb.velocity = (aimPoint - barrel.transform.position).normalized * bulletSpeed;
        clone.transform.rotation = Quaternion.LookRotation(rb.velocity);
        shooting = false;
    }
}
