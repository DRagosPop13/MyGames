using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class player : MonoBehaviour
{
    public Animator animator;

    public Slider healthBar;
    public Slider thirstBar;
    public Slider hungerBar;

    float timer = 0;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }

        timer += Time.deltaTime;
        if( timer >= 1) 
        {
            hungerBar.value -= 1;
            thirstBar.value -= 5;
            if( hungerBar.value == 0 || thirstBar.value == 0 )
            {
                healthBar.value -= 2;
                if( healthBar.value == 0 )
                    gameOver.SetActive(true);
            }
            timer = 0;
        }

    }
}

