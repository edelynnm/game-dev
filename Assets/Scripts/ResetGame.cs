using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    private bool _gameOver = false;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject maze;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameOver)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _gameOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Debug.Log("Restarting game...");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _gameOver = true;
            audioSource.Play();
            gameOverScreen.SetActive(true);
            maze.GetComponent<TiltMovement>().enabled = false;
        }
    }
}
