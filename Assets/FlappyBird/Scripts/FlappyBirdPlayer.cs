using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float flapper = 8;
    [SerializeField] private LogicScript logic;

    [SerializeField] private GameObject player;
    private bool birdAlive = true;
    public bool birdExists = false;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive) 
        {
            rb.velocity = Vector2.up * flapper;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdAlive= false;
    }
}
