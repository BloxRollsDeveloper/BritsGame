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
        _button.onClick.AddListener(TaskOnClick);
       _audioSource = GetComponent<AudioSource>(); 
       
    }
    
    void TaskOnClick()
    {
        int randomSound = Random.Range(0, buttonSfx.Length);
        _audioSource.PlayOneShot(buttonSfx[randomSound]);
    }
}
