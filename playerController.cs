using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playerController : MonoBehaviour
{

    public float speed;
    public int room;
    public Text countText;
    public Text lifeText;
    public Text winText;
    public Text scoreText;
    private Rigidbody rb;
    private int count;
    private int lives;
    private int score;
    public GameObject Player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        room = 1;
        lives = 3;
        SetCountText();
        winText.text = "";
        SetCountText();
    }

    void FixedUpdate() //Move the player around
    {
        if (lives < 1)
        {
            enabled = false;
            winText.text = "Game Over!  You ran out of lives!";
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) //when we touch the collectables
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false); //turn them off
            score = score + 1;
            count = count + 1; //increase our count
            SetCountText(); //update the score text
        }
        if (other.gameObject.CompareTag("Red Pick Up"))
        {
            other.gameObject.SetActive(false); //turn them off
            lives = lives - 1; //increase our count
            score = score - 1; 
            SetCountText(); //update the lives text
        }
    }

    void SetCountText()
    {
        lifeText.text = "Lives: " + lives.ToString();
        scoreText.text = "Score: " + score.ToString();
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            if (room == 2)
            {
                countText.fontStyle = FontStyle.Bold;
                winText.text = "You Win!";
            }

            if (room == 1)
            {
                transform.position = new Vector3(38.21f, 1, -5.59f);   //GO TO NEXT LEVEL
                count = 0;
                lives = 3;
                room = 2;
                lifeText.text = "Lives: " + lives.ToString();
                scoreText.text = "Score: " + score.ToString();
                countText.text = "Count: " + count.ToString();
            }

        }
    }

}