using System;
using UnityEngine;

public class AmbienceController : MonoBehaviour
{
   private void Awake()
   {
      DontDestroyOnLoad(gameObject);
   }
}
