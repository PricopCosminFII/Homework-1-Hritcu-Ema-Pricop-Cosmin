using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject Cactus1;
    public GameObject Cactus2;
    
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        distance = Vector3.Distance(Cactus1.transform.position, Cactus2.transform.position);
        if (distance < 1.0f)
            animator.SetBool("isClose", true);
        else
            animator.SetBool("isClose", false);



    }
}
