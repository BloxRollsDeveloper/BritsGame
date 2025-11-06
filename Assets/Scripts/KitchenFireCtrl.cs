using UnityEngine;

public class KitchenFireCtrl : MonoBehaviour
{
    public Animator animator;
    public bool kitchenSetOnFire = false;
//To make the kitchen burn, set the "kitchenSetOnFire" bool true
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (kitchenSetOnFire)
        {
            //sets it on fire
            animator.SetBool("OnFire", true);
        }
        else
        {
            //makes sure that the kitchen is otherwise not on fire.
            animator.SetBool("OnFire", false);
        }
    }
}
