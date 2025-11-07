using UnityEngine;

public class GameWindowController : MonoBehaviour
{
 
    public bool gameActivated = false;
    public GameObject[] minigameObjects;
    public bool childrenEnabled = false;
    private GameWon _gameWon;
    private void Awake()
    {
        _gameWon = GetComponent<GameWon>();
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

        
        if (GameObject.FindGameObjectsWithTag("Bolt").Length == 0 && childrenEnabled)
        { 
            GameWon();
        }
        
        
    }

    void GameWon()
    {
       
        _gameWon.MiniGameWon = true;
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
