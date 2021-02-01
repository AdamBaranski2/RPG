using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Sprint", true);
        }
        else
        {
            animator.SetBool("Sprint", false);
        }

        if (Input.GetKeyUp(KeyCode.Alpha1)) UseSkill(1);

        if (Input.GetKeyUp(KeyCode.Alpha2)) UseSkill(2);

        if (Input.GetKeyUp(KeyCode.Alpha3)) UseSkill(3);

        if (Input.GetKeyUp(KeyCode.Alpha4)) UseSkill(4);
    }
    void UseSkill(int skillNumber)
    {
        animator.SetTrigger("Skill" + skillNumber);

    }
    public void Jump()
    {
        animator.SetTrigger("Jump");
    }


}
