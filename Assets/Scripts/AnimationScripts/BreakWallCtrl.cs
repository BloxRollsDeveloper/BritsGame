using UnityEngine;

public class BreakWallCtrl : MonoBehaviour
{
    public Animator animator;

    public GameWon _gameWon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameWon.MiniGameWon)
        {
            animator.SetBool("WallBroken", true); 
            _gameWon.MiniGameWon = false;
        }
    }
}
