using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public float speed;
    
	void Update ()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
        //transform.rotation = Quaternion.identity;
	}
}
