using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    
    Vector2 movement = Vector2.zero;
    [SerializeField]
    float speed = 5;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

        anim.Play("Idle");
    }


    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
        
    }

    void OnMove(InputValue value)
    {
        Vector2 vector = value.Get<Vector2>();
        movement = Vector2.one * vector * speed;

        if(movement.magnitude == 0)
        {
            anim.Play("Idle");
        }
        else if (movement.x < 0)
        {
            anim.Play("WalkLeft");
        }

        else if (movement.x > 0)
        {
            anim.Play("WalkRight");
        }
    }


}
