using UnityEngine;
using System.Collections;
using InControl;
public class Shoot : MonoBehaviour
{
    public GameObject barrel;
    public GameObject bullet;

    Animator anim;
    InputDevice inputDevice;
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
            if(!shooting)
            {
                shooting = true;
                Fire();
            }
        }
    }

    void Fire()
    {
        anim.SetTrigger("Shoot");
        Instantiate(bullet, barrel.transform.position, transform.rotation);
        shooting = false;
    }
}
