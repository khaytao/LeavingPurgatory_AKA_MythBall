using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    [SerializeField] private GameObject door;
    private int _remainedCollectors = 1;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioSource _glassSound;
    [SerializeField] private AudioSource _winningSound;
    [SerializeField] private GameObject winningPanel;
    void Start()
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

    public void GlassAudio()
    {
        _glassSound.Play();
    }

    public void Winning()
    {
        _winningSound.Play();
        winningPanel.SetActive(true);
    }


    public void Collected()
    {
        _audioSource.Play();
        _remainedCollectors--;
        if (_remainedCollectors == 0)
        {
            OpenGate();
        }
    }

    private void OpenGate()
    {
        door.SetActive(false);
    }
    
}
