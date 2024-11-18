using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Player : Singletone<Player>
{
    [field: SerializeField] public PlayerSO Data { get; private set; }
    [field: SerializeField] public ItemData itemData { get; private set; }

    [field: Header("Animations")]
    [field: SerializeField] public PlayerAnimationData AnimationData { get; private set; }

    public Animator Animator { get; private set; }
    public CharacterController Controller { get; private set; }

    public PlayerController Input { get; private set; }
    public PlayerStateMachine StateMachine { get; private set; }
    
    public Action addItem;

    private void Awake()
    {
        AnimationData.Initialize();
        Animator = GetComponentInChildren<Animator>();
        Controller = GetComponent<CharacterController>();

        Input = GetComponent<PlayerController>();
        StateMachine = new PlayerStateMachine(this);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
