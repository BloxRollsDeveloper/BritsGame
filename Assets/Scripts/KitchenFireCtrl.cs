using UnityEngine;

public class KitchenFireCtrl : MonoBehaviour
{
    public Animator animator;
    public bool kitchenSetOnFire = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (kitchenSetOnFire)
        {
            animator.SetBool("OnFire", true);
        }
        else
        {
            animator.SetBool("OnFire", false);
        }
    }
}
