using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private float movementX;
    private float movementY;

    public bool CanMove { get; set; }

    private void Awake()
    {
        CanMove = true;
    }

    private void Update()
    {
        if (CanMove)
        {
            movementX = Input.GetAxisRaw("Horizontal");
            movementY = Input.GetAxisRaw("Vertical");

            transform.position += (new Vector3(movementX, movementY)) * Time.deltaTime * speed ;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Se inicia el dialogo");
        CanMove = false;
        DialogueManager.Instance.StartDialogue(0);
    }
}
