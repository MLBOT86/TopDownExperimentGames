using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private const string IS_RUNNING = "IsRunning";



    private void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Debug.Log("hi");
        animator.SetBool(IS_RUNNING, Player.Instance.IsRunningCheck());
        AdjustPlayerFacingDirection();
    }
    private void AdjustPlayerFacingDirection()
    {
        Vector3 mousePos = GameInput .Instance.GetMousePosition();
        Vector3 PlayerPosition = Player.Instance.GetPlayerScreenPosition();

        if(mousePos.x < PlayerPosition.x) {
            spriteRenderer.flipX = true;
        } else {
            spriteRenderer.flipX= false;
        }
    }
}
