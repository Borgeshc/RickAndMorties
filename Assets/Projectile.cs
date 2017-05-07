using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Health>().TookDamage(2);
            Destroy(gameObject);
        }
        else if(other.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
