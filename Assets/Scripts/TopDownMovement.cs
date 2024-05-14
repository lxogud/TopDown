using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{ 
    // 실제 이동 처리 컴포넌트
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    
    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate() 
    {
        // FixedUpdate는 물리업데이트관련
        // rigidbodyd의 값을 바꾸니까 FixedUpdate
        ApplyMoveMent(movementDirection);
    }
    private void ApplyMoveMent(Vector2 direction) 
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }
}
