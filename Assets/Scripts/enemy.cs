using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class enemy : MonoBehaviour
{ 
    public int velocity;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    public int points = 10;
    private ScoreManager _scoreManager;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigidbody2D.position = new Vector2(_rigidbody2D.position.x,_rigidbody2D.position.y + velocity*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diamond")
        {
            _animator.SetBool("Explosion", true);
            AddPoint();
            Destroy(this.gameObject, 1);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            _animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1);
        }
    }
    private void AddPoint()
    {
        if (_scoreManager != null)
        {
            _scoreManager.AddPoints(points);
        }
    }
}
