using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObject : MonoBehaviour
/*{
    
    private void OnTriggerEnter2D(Collider other)
    {
        if (gameObject.tag == "Enemy")
        {
            if (other.tag == "Player")
            {
                gameover();
            }
        }
    }
    void gameover()
    {
        SceneManager.LoadScene(0);
    }
}

{
    void Awake()
    {
        BoxCollider2D bc;
        bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
        bc.size = new Vector2(3.0f, 1.0f);
        bc.isTrigger = true;

        gameObject.transform.localScale = new Vector3(3.0f, 1.0f, 1.0f);
        gameObject.transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("GameObject2 collided with " + col.Enemy);
    }
}*/
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}