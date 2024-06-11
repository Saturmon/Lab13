using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private AudioSource _audioSource;
    public int velocityx;
    public int velocityy;
    private Rigidbody2D _rigidbody2D;
    public GameObject _gameObject;
    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t") == true)
        {
            Instantiate(_gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            _audioSource.Play();
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x + velocityx * Time.deltaTime, _rigidbody2D.position.y);
        }

        if (Input.GetKey("a"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x - velocityx * Time.deltaTime, _rigidbody2D.position.y);
        }
        if (Input.GetKey("w"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, _rigidbody2D.position.y + velocityy * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, _rigidbody2D.position.y - velocityy * Time.deltaTime);
        }
        
    }
    
}
