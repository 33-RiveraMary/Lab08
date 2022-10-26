using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move vertically
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        //restrict movement within scene
        if (transform.position.y > 4.87f)
        {
            transform.position = new Vector3(-8.5f, 4.87f, 0f);
        }
        else if (transform.position.y < -2.87f)
        {
            transform.position = new Vector3(-8.5f, -2.87f, 0f);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
