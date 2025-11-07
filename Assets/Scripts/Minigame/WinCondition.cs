using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public bool miniGameWon = false;
    public bool gameActivated;
    
    private void Awake()
    {
        gameActivated = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActivated)
        {
            gameObject.SetActive(true);
            gameActivated = false;
            
        }

        if (GameObject.FindGameObjectsWithTag("Bolt").Length == 0)
        { 
            gameWon();
        }
        
    }

    void gameWon()
    {
        miniGameWon = true;
        //add script to change animate state here.;
        gameObject.SetActive(false);
        
        
    }
}
