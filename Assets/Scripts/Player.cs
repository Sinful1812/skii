using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody rb;

    [SerializeField] 
    private float forcePower;

    [SerializeField] 
    private float xInput;

    [SerializeField]
    private int score;

    [SerializeField]
    private int hp;

    public int HP
    {
        get { return hp; }
        set
        {
            hp = value;

        }
    }
    public int Score { get { return score; } set { score = value; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    

    void Update()
    {
       
        MoveLeftOrRight();
        MoveForwardOrBack();
    }
    private void MoveLeftOrRight()
    {
        xInput = Input.GetAxis("Horizontal");
        rb.AddForce(xInput * Vector3.right * forcePower);
    }
    private void MoveForwardOrBack()
    {
        float zInput = Input.GetAxis("Vertical");
        rb.AddForce(zInput * Vector3.forward * forcePower);
    }





}
