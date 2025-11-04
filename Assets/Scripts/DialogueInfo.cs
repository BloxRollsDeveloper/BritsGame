using UnityEngine;

[CreateAssetMenu (fileName = "DialogueInfo", menuName = "DialogueInfo", order = 1)]
public class DialogueInfo : ScriptableObject
{
    public string characterName;
    public Sprite portrait;
    
    public int optionIndex;
    
    public string[] openingLines;
    
    public string option1, option2;
    
    public string[] option1Lines;
    public string[] option2Lines;
    
    public string[] closingLines;
}