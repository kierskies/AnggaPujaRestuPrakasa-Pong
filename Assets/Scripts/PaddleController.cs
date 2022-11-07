using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(getInput());
    }

    private Vector2 getInput()
    {
        //Input Key
        if (Input.GetKey(upKey))
        {
            //Go Up
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            //Go Down
            return Vector2.down * speed;
        }
        
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        // Debug.Log("Paddle Speed: " + movement);
        rig.velocity = movement;
    }
}
