using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crazyDiamond : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D _Rigidbody2D;
    public int velocity;
    // Start is called before the first frame update
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _Rigidbody2D = GetComponent<Rigidbody2D>();
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
        _Rigidbody2D.position = new Vector2(_Rigidbody2D.position.x, _Rigidbody2D.position.y + velocity * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "KIRA")
        {
            _animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1);
        }
        if (collision.gameObject.tag == "Pared")
        {
            _animator.SetBool("Explosion", true);
            Destroy(this.gameObject, 1);
        }
    }
}
