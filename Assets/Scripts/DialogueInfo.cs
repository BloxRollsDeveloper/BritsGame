using UnityEngine;

[CreateAssetMenu (fileName = "DialogueInfo", menuName = "DialogueInfo", order = 1)]
public class DialogueInfo : ScriptableObject
{
    public string characterName;
    public Sprite portrait;
    
    public int optionIndex;
    
    public string[] openingLines;
    public AudioClip[] openingVoiceClips;
    
    public string option1, option2;
    
    public string[] option1Lines;
    public AudioClip[] option1VoiceClips;
    public string[] option2Lines;
    public AudioClip[] option2VoiceClips;
    
    public string[] closingLines;
    public AudioClip[] closingVoiceClips;
}