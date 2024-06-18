using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

public class CreadorDeEnemigos : MonoBehaviour
{
    public GameObject enemigos;
    public int velocity;
    public int direction;
    private Rigidbody2D _rigidbody2D;
    public float tiempoDeCrearEnemigo=2;
    public float tiempoActualDelEnemigo=0;
    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActualDelEnemigo = tiempoActualDelEnemigo + Time.deltaTime;
        if (tiempoActualDelEnemigo >= tiempoDeCrearEnemigo)
        {
            tiempoActualDelEnemigo = 0;
            CrearEnemigo();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            if (direction == 1)
            {
                direction = -1;
            }
            else if (direction == -1)
            {
                direction = 1;
            }
        }
    }
    private void FixedUpdate()
    {
        _rigidbody2D.position = new Vector2(_rigidbody2D.position.x + velocity*direction * Time.deltaTime, _rigidbody2D.position.y);
    }
    public void CrearEnemigo()
    {
        Instantiate(enemigos,transform.position,transform.rotation);
    }
}
