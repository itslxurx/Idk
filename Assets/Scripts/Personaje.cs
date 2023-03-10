using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] int alturaSalto;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Jump", true);
            rigidbody.AddForce(Vector2.up * alturaSalto);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "suelo")
        {
            animator.SetBool("Jump", false);
        }

        if(collision.transform.tag == "enemigo")
        {
            GameManager.Instancia.Perder();
            Debug.Log("perder");
        }

    }


}
