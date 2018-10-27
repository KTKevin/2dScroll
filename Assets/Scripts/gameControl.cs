using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameControl : MonoBehaviour {
    public GameObject gameOverText;
    public bool gameOver = false;
    public static gameControl instance;
    public float scrollSpeed = -1.5f;
   
    // Use this for initialization
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start () {
        gameOverText.SetActive(false);
		
	}

    // Update is called once per frame
    void Update() {
        if (gameOver && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
		
	}
    public void birdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
