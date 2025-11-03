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

   public DialogueInfo currentNPC;
   private string[] currentConversation;
   
    private int index;
    
    private Camera _mainCamera;
    
    void Start()
    {
        _mainCamera = Camera.main;
    }
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            var hit = Physics2D.Raycast(_mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue()), Vector2.zero);

            if (hit.collider != null)
            {
                if (!hit.collider.CompareTag("Dude")) return;
                hit.transform.TryGetComponent(out NPCManager npc);

                if (currentNPC != null)
                {
                    if (npc.info.name != currentNPC.name)
                    {
                        index = 0;
                    }
                }
                
                currentNPC = npc.info;
                currentConversation = npc.info.openingLines;
                dialogueText.text = currentNPC.openingLines[index];
            }
            
            if (currentNPC == null) return;
            
            if (dialogueText.text == currentNPC.openingLines[index])
            {
                NextLine();
            }
        }
    }

    void NextLine()
    {
        if (index < currentNPC.openingLines.Length - 1)
        {
           
            dialogueText.text = currentNPC.openingLines[index];
            index++;
        }
        else
        {
            dialogueText.enabled = false;
            option1.enabled = true;
            option2.enabled = true;
        }
    }
}