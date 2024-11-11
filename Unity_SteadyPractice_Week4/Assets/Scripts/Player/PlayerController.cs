using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    private float moveSpeed;
    private float jumpPower;
    private Vector2 curMovementInput;
    public LayerMask groundLayerMask;



    [Header("Look")]
    public Transform cameraContainer; // 카메라 방향을 지정할 트랜스폼
    public float minXLook; // 회전 범위 최저값
    public float maxXLook; // 회전 범위 최대값
    private float camCurXRot; // 최종 출력 마우스 델타값
    public float lookSensitivity; // 회전 민감도
    private Vector2 mouseDelta; // inputsystem으로 입력 받는 마우스 델타값
    public bool canLook = true;
    public bool isInputBlocked = false; // 입력을 막는 플래그

    [Header("event")]
    public Action inventory;
    public event Action<bool> onMoveEvent; // 이동 애니 이벤트
    public event Action onJumpEvent; // 점프 애니 이벤트

    private Rigidbody _rigidbody;
    public CapsuleCollider _capsuleCollider;

    public  void Init()
    {

    }
}
