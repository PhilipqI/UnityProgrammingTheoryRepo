using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    private bool m_GameIsActive;

    // ENCAPSULATION
    public bool IsGameActive
    {
        get
        {
            return m_GameIsActive;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        m_GameIsActive = true;
    }

    public void RestartGame()
    {
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        m_GameIsActive = false;
        gameOverMenu.SetActive(true);
    }
}
