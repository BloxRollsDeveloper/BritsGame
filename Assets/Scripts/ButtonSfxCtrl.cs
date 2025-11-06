using UnityEngine;
using UnityEngine.UI;

public class ButtonSfxCtrl : MonoBehaviour
{
    public AudioClip[] buttonSfx;
    private AudioSource _audioSource;
    private Button _button;
    
    void Start()
    {
        _button = GetComponent<Button>();
       _audioSource = GetComponent<AudioSource>(); 
    }

    void Update()
    {
        if (_button.)
        {
            int randomSound = Random.Range(0, buttonSfx.Length);
            _audioSource.PlayOneShot(buttonSfx[randomSound]);
        }
    }
}
