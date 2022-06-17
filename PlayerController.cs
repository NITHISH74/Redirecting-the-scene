using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public GameObject WinText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Page2");
        }

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Sphere")
        {
          Destroy(collision.gameObject);
            WinText.SetActive(true);
        }
    }
}
