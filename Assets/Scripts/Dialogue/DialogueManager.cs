using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance; 
    public GameObject dialogueCanvas; 
    public TMPro.TMP_Text dialogueText; 
    public TMPro.TMP_Text characterNameText; 
    public AudioSource dialogueAudioSource; 
    public GameObject choicesContainer; 
    public TMPro.TMP_Text[] choiceButtons; 
    
    private DialogueInfo currentDialogue; 
    private string[] currentLines; 
    private AudioClip[] currentVoiceClips;
    private int currentLineIndex; 
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartDialogue(DialogueInfo dialogue)
    {
        currentDialogue = dialogue;
        currentLines = dialogue.openingLines;
        currentVoiceClips = dialogue.openingVoiceClips;
        currentLineIndex = 0;

        dialogueCanvas.SetActive(true);
        characterNameText.text = dialogue.characterName;

        ShowLine();
    }

    private void ShowLine()
    {
        if (currentLineIndex < currentLines.Length)
        {
            string line = currentLines[currentLineIndex];
            AudioClip voiceClip = GetVoiceClip(currentLineIndex);

            dialogueText.text = line;
            PlayVoiceClip(voiceClip);

            currentLineIndex++;
        }
        else
        {
            EndDialogue();
        }
    }

    private AudioClip GetVoiceClip(int index)
    {
        if (currentVoiceClips != null && index < currentVoiceClips.Length)
        {
            return currentVoiceClips[index];
        }
        return null;
    }

    private void PlayVoiceClip(AudioClip clip)
    {
        if (dialogueAudioSource != null)
        {
            dialogueAudioSource.Stop();
            if (clip != null)
            {
                dialogueAudioSource.clip = clip;
                dialogueAudioSource.Play();
            }
        }
    }

    public void ChooseOption(int optionIndex)
    {
        if (optionIndex == 1)
        {
            currentLines = currentDialogue.option1Lines;
            currentVoiceClips = currentDialogue.option1VoiceClips;
        }
        else if (optionIndex == 2)
        {
            currentLines = currentDialogue.option2Lines;
            currentVoiceClips = currentDialogue.option2VoiceClips;
        }
        currentLineIndex = 0;
        ShowLine();
    }

    public void OnClickContinue()
    {
        ShowLine();
    }

    private void EndDialogue()
    {
        dialogueCanvas.SetActive(false);
    }
}