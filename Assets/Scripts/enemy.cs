using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Diamond")
        {
            _animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1);
        }
    }
}
