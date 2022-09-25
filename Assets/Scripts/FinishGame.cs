using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    [SerializeField] GameObject victoryScreen;

    private bool _win = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (_win)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Debug.Log("Restarting game...");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            _win = true;
            audioSource.Play();
            GetComponent<MeshRenderer>().material.color = Color.green;
            victoryScreen.SetActive(true);
        }
    }
}
