using UnityEngine;

public class BreakWallCtrl : MonoBehaviour
{
    private WinCondition _winCondition;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        _winCondition = GetComponent<WinCondition>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_winCondition.miniGameWon)
        {
            animator.SetBool("WallBroken", true);
            _winCondition.miniGameWon = false;
        }
    }
}
