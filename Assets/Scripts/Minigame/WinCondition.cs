using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public bool won = false;
    public bool gameActivated = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("Bolt").Length == 0)
        { 
            MinigameWon();
        }
        
    }

    void MinigameWon()
    {
        won = true;
        //add script to change animate state here.
        gameObject.SetActive(false);
        
    }
}
