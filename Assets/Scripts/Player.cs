using UnityEngine;
using UnityEngine.SceneManagement;

public class P : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetMouseButton(0)) {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0) {
                rb.AddForce(Vector2.left * moveSpeed);
            
            }
            else { 
            rb.AddForce(Vector2.right * moveSpeed);
            
            }


        
        }
        else {

            rb.linearVelocity = Vector2.zero;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block") {

            SceneManager.LoadScene("SampleScene");
        }
    }





}
