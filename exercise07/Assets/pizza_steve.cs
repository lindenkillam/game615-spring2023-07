using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza_steve : MonoBehaviour
{
    public Animator animator;
    public string animationName = "Walk anim";
    // Start is called before the first frame update
    void Start()
    {
        animator.Play(animationName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
