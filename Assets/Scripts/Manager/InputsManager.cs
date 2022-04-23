using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsManager : MonoBehaviour
{
    public static InputsManager Instance;

    [HideInInspector] public Vector2 moveDirection;

    [HideInInspector] public bool attack;

    [HideInInspector] public bool pick;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }

    void Inputs()
    {
        //movement
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        moveDirection = moveDirection.normalized;

        //Attack
        attack = Input.GetKeyDown(KeyCode.Space);

        //pick object
        pick = Input.GetKeyDown(KeyCode.Q);
    }
}
