using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float restatDelay = 1f;

    public GameObject completeLevelUI;

    public void Completelevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Restart();
            Invoke("Restart", restatDelay);
        }
    }

    public void CompleteLevel ()
    {
        Debug.Log ("LEVEL WON");
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
