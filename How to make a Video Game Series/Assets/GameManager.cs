using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject levelCompleteUI;

    public void EndGame()
    {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel()
    {
        if (gameHasEnded == false)
        {
            FindObjectOfType<AudioManager>().Play("Won");
            levelCompleteUI.SetActive(true);
        }
    }

    #region Restart

    private void FixedUpdate()
    {
        if (Input.GetKey("r"))
        {
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    #endregion
}
