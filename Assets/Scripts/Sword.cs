using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private PlayerControls playerControls;
    private Animator anim;

    private void Awake()
    {
        playerControls = new PlayerControls();
        anim = GetComponent<Animator>();
    }

    private void OnEnable() => playerControls.Enable();

    private void OnDisable() => playerControls.Disable();

    void Start()
    {
        playerControls.Combat.Attack.performed += _ => Attack();
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
        Debug.Log("Attack!");
    }
}
