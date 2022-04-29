using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number2 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision Confirmed!");
        speed = speed * -1;
    }
}
