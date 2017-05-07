using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public float maxHealth;
    float health;
    Animator anim;
    AIMovement movement;

    private void Start()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();
        movement = GetComponent<AIMovement>();
    }
    
    public void TookDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            StartCoroutine(Died());
        }
    }

    IEnumerator Died()
    {
        movement.cantMove = true;
        anim.SetTrigger("Died");
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
