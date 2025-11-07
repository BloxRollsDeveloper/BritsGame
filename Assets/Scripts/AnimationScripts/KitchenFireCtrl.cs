using UnityEngine;
using UnityEngine.SceneManagement;

public class KitchenFireCtrl : MonoBehaviour
{
    public Animator animator;
    public bool kitchenSetOnFire = false;
//To make the kitchen burn, set the "kitchenSetOnFire" bool true
    public bool endSceneAnimation = false;
    public GameObject[] buttons;
    public GameObject[] npcSprites;
    public AudioClip fireAlarm;
    private AudioSource _audioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
        
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
            foreach (GameObject obj in buttons)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in npcSprites)
            {
                obj.SetActive(false);
            }
            animator.SetBool("EndScene", true);
        }
    }

    public void onAnimationEnd()
    {
        SceneManager.LoadScene("EndScreen");
    }
    public void StartFireAlarm()
    {
        _audioSource.PlayOneShot(fireAlarm);  
    }
}
