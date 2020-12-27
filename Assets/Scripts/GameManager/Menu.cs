using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioSource pressingButtonSound;
    
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    // quits the game
    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);

    }
    
    public void SelectLevel1()
    {
        SceneManager.LoadScene(3);

    }
    public void SelectLevel2()
    {
        SceneManager.LoadScene(4);

    }
    public void SelectLevel3()
    {
        SceneManager.LoadScene(5);

    }
    public void SelectLevel4()
    {
        SceneManager.LoadScene(6);

    }

    public void PressingButtonSound()
    {
        pressingButtonSound.Play();
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
    }

}
