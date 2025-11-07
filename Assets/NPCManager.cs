using System;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public DialogueInfo info;
    
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = info.portrait;
    }
}
