using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{   
    [SerializeField]
    private InputActionReference m_moveReference;

    public float speed;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 moveInput= m_moveReference.action.ReadValue<Vector2>();
        
    }
}