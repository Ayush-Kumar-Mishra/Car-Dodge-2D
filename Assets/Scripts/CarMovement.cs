using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour
{
    public float speed;
    float xInput,yInput;
    public GameObject imageGameover; 
    public GameObject scoreText;
    public AudioSource crashSound;
    public AudioSource driftSound;

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        transform.position = new Vector2(Mathf.Clamp(transform.position.x + xInput * speed,-2.3f,2.32f), Mathf.Clamp(transform.position.y + yInput * speed,-4.5f,4.5f));

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            driftSound.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            crashSound.Play();
            Destroy(collision.gameObject);
            Time.timeScale = 0;
            imageGameover.SetActive(true);
            Destroy(scoreText);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
