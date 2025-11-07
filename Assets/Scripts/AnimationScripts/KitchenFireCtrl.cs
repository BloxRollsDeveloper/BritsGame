using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenFireCtrl : MonoBehaviour
{
    public Animator animator;
    public bool kitchenSetOnFire = false;
//To make the kitchen burn, set the "kitchenSetOnFire" bool true
    public bool endSceneAnimation = false;
    public GameObject[] buttons;
    public AudioClip fireAlarm;
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

        if (endSceneAnimation)
        {
            foreach (GameObject button in buttons)
            {
                button.SetActive(false);
            }
            animator.SetBool("EndScene", true);
        }
    }

    public void onAnimationEnd()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
