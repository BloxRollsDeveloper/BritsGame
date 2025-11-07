using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public bool miniGameWon = false;
    public bool gameActivated = false;
    public GameObject[] minigameObjects;
    public bool childrenEnabled = false;
    private void Awake()
    {
        DisableChildren();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActivated)
        {
            EnableChildren();
            gameActivated = false;
            
        }

        if (childrenEnabled)
        {
            if (GameObject.FindGameObjectsWithTag("Bolt").Length == 0)
            { 
                GameWon();
            }
        }
            
        
    }

    void GameWon()
    {
       
        miniGameWon = true;
        //add script to change animate state here.;
        DisableChildren();
        
        
    }

    
    
    void DisableChildren()
    {
        foreach (GameObject miniGameObjs in minigameObjects)
        {
            miniGameObjs.SetActive(false);
        }
        childrenEnabled = false;
    }

    void EnableChildren()
    {
        foreach (GameObject miniGameObjs in minigameObjects)
        {
            miniGameObjs.SetActive(true);
        }
        childrenEnabled = true;
    }
}
