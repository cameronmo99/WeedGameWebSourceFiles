using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public Rigidbody rb;
    public float jumpAllowed;
    public float rampTimer;
    public int coinsPickedUp;
    //Variable for player movement and interactions with object
    
    public Generation genGrab;
    //used to grab variables from otehr script

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Get rigidbody
    }

    void Update()
    {
        Movement();
        //Allow movement function to be used

        if (Input.GetKey(KeyCode.Escape))
        {
            if ((int)genGrab.distanceTrack > ScoreBetweenScenes.highScore)
            {
                ScoreBetweenScenes.highScore = (int)genGrab.distanceTrack;
                PlayerPrefs.SetInt("highScore", ScoreBetweenScenes.highScore);
                SceneManager.LoadScene(0);
            }
            //If user presses escape key, save highscore if it is higher than the previous set highscore

            SceneManager.LoadScene(0);
            //Otherwise load menu scene
        }
    }

    void FixedUpdate()
    {
        Jump();
        //Allow jump to be used 
    }

    void Movement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
        //Make player move forwards constantly

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //If player presses A key, move to the left

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //If the player presses D key, move to the left

        if (transform.position.x > 4)
        {
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
        }
        //Prevent player from moving past limit

        if (transform.position.x < -4)
        {
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        }
        //Prevent player from moving past the limit
    }

    void Jump()
    {
        jumpAllowed = jumpAllowed + Time.deltaTime;
        //Cooldown timer
        
        if(jumpAllowed > 1.75f)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpForce * 20);

                jumpAllowed = 0f;
            }
            //If cooldown timer is free, let user jump and reset the cooldown timer
        }
    }

    public void mobileMoveLeft()
    {
        //Used for mobile control to move left
        transform.Translate(Vector3.left * speed);
    }


    public void mobileMoveRight()
    {
        //Used for mobile control to move right
        transform.Translate(Vector3.right * speed);
    }


    public void mobileJump()
    {
        //Used for mobile control jump
        jumpAllowed = jumpAllowed + Time.deltaTime;

        if(jumpAllowed > 1.75f)
        {
            rb.AddForce(Vector3.up * jumpForce * 20);

            jumpAllowed = 0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);

            coinsPickedUp++;
            CoinsBetweenScenes.coins++;
        }
        //If player hits coin, add to static variable to track coins and destroy the touched coin

        else if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        //If player hits an enemy or obstacle, go back to main menu and destroy object

        else if (other.gameObject.CompareTag("Ramp"))
        {
            rb.AddForce(Vector3.up * jumpForce * 50);
        }
        //If player hits ramp, force player to move up

        else if (other.gameObject.CompareTag("Teleporter"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, 21, transform.position.z);
        }
        //If player hits teleporter, set player transform to top lanes

        else if (other.gameObject.CompareTag("Stopper"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
        //If player hits the stopper, set player to middle lane

        else if(other.gameObject.CompareTag("Teleporter Low"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
        //If player hits teleporter, set player to middle lanes

        else if (other.gameObject.CompareTag("Stopper Low"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, -12, transform.position.z);
        }
        //If player hits stopper, set to the lower lanes
    }
}