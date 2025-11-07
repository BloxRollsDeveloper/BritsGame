using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Button option1, option2;
    private TMP_Text option1Text, option2Text; 

   public DialogueInfo currentNPC;
   private string[] currentConversation;
   
    private int index;
    private bool dialogueActive = false;
    private bool showingChoices = false;
    private bool inBranch = false;
    
    
    
    
    private Camera _mainCamera;
    
    void Start()
    {
        _mainCamera = Camera.main;
        dialogueText.enabled = false;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        
        option1Text = option1.GetComponentInChildren<TMP_Text>();
        option2Text = option2.GetComponentInChildren<TMP_Text>();
        
        option1.onClick.AddListener(OnOption1Selected);
        option2.onClick.AddListener(OnOption2Selected);
    }
    
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var hit = Physics2D.Raycast(_mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue()), Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Dude"))
            {
                hit.transform.TryGetComponent(out NPCManager npc);

               
                if (npc != null)
                {
                   
                    if (currentNPC != null && npc.info.name != currentNPC.name)
                    {
                        ResetDialogue();
                    }
                    
                    currentNPC = npc.info;
                    currentConversation = npc.info.openingLines;
                    
                    
                    if (!dialogueActive && !showingChoices)
                    {
                        StartDialogue();
                    }
                    else if (dialogueActive && !showingChoices)
                    {
                        NextLine();
                    }
                }
            }
            else if (dialogueActive && !showingChoices)
            {
                
                NextLine();
            }
        }
    }

    void StartDialogue()
    {
        dialogueActive = true;
        showingChoices = false;
        inBranch = false;
        index = 0;
        dialogueText.enabled = true;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        currentConversation = currentNPC.openingLines;
        dialogueText.text = currentConversation[index];
        index++;
        AudioClip voiceClip = currentNPC.openingVoiceClips[0];
    }

    void NextLine()
    {
        if (index < currentConversation.Length)
        {
            dialogueText.text = currentConversation[index];
            index++;
        }
        else
        {
           
            if (!inBranch && currentConversation == currentNPC.openingLines)
            {
                
                ShowChoices();
            }
            else if (inBranch)
            {
                
                ShowClosingLines();
            }
            else
            {
                
                ResetDialogue();
            }
        }
    }

    void ShowChoices()
    {
        dialogueText.enabled = false;
        dialogueActive = false;
        showingChoices = true;
        
        
        if (option1Text != null)
            option1Text.text = currentNPC.option1;
        if (option2Text != null)
            option2Text.text = currentNPC.option2;
        
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(true);
    }

    void OnOption1Selected()
    {
        Debug.Log("Option 1 selected");
        showingChoices = false;
        inBranch = true;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        
        
        currentConversation = currentNPC.option1Lines;
        index = 0;
        dialogueActive = true;
        dialogueText.enabled = true;
        AudioClip voiceClip = currentNPC.option1VoiceClips[0];
        
        if (currentConversation.Length > 0)
        {
            dialogueText.text = currentConversation[index];
            index++;
        }
        else
        {
            
            ShowClosingLines();
        }
    }

    void OnOption2Selected()
    {
        Debug.Log("Option 2 selected");
        showingChoices = false;
        inBranch = true;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        
        
        currentConversation = currentNPC.option2Lines;
        index = 0;
        dialogueActive = true;
        dialogueText.enabled = true;
        AudioClip voiceClip = currentNPC.option2VoiceClips[0];
        
        if (currentConversation.Length > 0)
        {
            dialogueText.text = currentConversation[index];
            index++;
        }
        else
        {
            
            ShowClosingLines();
        }
    }

    void ShowClosingLines()
    {
        inBranch = false;
        currentConversation = currentNPC.closingLines;
        index = 0;
        dialogueActive = true;
        dialogueText.enabled = true;
        AudioClip voiceClip = currentNPC.closingVoiceClips[0];
        
        if (currentConversation.Length > 0)
        {
            dialogueText.text = currentConversation[index];
            index++;
        }
        else
        {
            ResetDialogue();
        }
    }

    void ResetDialogue()
    {
        index = 0;
        dialogueActive = false;
        showingChoices = false;
        inBranch = false;
        dialogueText.enabled = false;
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
    }
    
    public void OnChoiceMade()
    {
        ResetDialogue();
    }
}