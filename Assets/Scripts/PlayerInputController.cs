using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    Animator anim;
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
        anim = GetComponentInChildren<Animator>();
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);

        if(moveInput != Vector2.zero)
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }
    }

    public void OnLook(InputValue value) 
    { 
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}
