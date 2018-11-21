using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCharacterController : MonoBehaviour {

    public float speed = 10.0f;
    public Text countText;
    public Text winText;
    public float jump = 10.0f;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        count = 7;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speed;
        float moveVertical = Input.GetAxis("Vertical") * speed;

        transform.Translate(moveHorizontal, 0, moveVertical);
      
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }

        if (other.gameObject.CompareTag("JumpPad"))
        {
            this.gameObject.GetComponent<Rigidbody>
                ().AddForce(Vector3.up * jump);
        }      
    }

    void SetCountText()
    {
        countText.text = "Objects Remaining: " + count.ToString();
        if (count == 0)
        {
            winText.text = "Great! Find the Exit!";
        }
    }
}

