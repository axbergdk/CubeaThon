using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1;
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("Game over");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        FindObjectOfType<Score>().stopScore = true;

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
