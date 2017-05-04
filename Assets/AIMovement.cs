using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour
{
    public float speed;

	void Update ()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
	}
}
