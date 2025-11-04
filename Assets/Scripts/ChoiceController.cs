using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceController : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Button;
    public GameObject Button2;
    public int Choice;
    
    public Dialogue DialogueController;

    public void Button1()
    {
        Debug.Log("Button1 clicked!"); 
        Choice = 1;
        
        if (DialogueController != null)
        {
            DialogueController.OnChoiceMade();
        }
    }

    public void Button2Method()
    {
        Debug.Log("Button2 clicked!"); 
        Choice = 2;
        
        if (DialogueController != null)
        {
            DialogueController.OnChoiceMade();
        }
    }
}