using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]

public class Collectible : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }




    // Update is called once per frame
    void Update()
    {


    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            anim.SetTrigger("Open");
            {
                Destroy(this.gameObject, 1f);
            }

            
        }
    }
}
