using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carscript : MonoBehaviour
{
    public float speed;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionExit2D(Collision2D finish)
    {
        if (finish.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(2);
        }
    }
    //private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
