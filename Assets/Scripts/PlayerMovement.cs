using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //board
    public Transform[] waypoint;
    //convert waypoint 1D ke 2D di void Start
    public Vector3[,] waypoints;
    public int boardSize = 7;
    [SerializeField] private float moveSpeed = 1f;
    [HideInInspector] public int waypointIndex = 0;
    [SerializeField] private int waypointX = 0;
    [SerializeField] private int waypointY = 0;
    public bool moveAllowed = false;
    public Vector2 targetDir;
    public int targetCounter;

    // Start is called before the first frame update
    void Start()
    {
        //uncomment this
        transform.position = waypoint[waypointIndex].transform.position;
        //itterate waypoint dan assign ke waypoints
        waypoints = new Vector3[boardSize, boardSize];
        for (int x = 0; x < boardSize; x++)
        {
            for (int y = 0; y < boardSize; y++)
            {
                waypoints[x, y] = waypoint[x + y * boardSize].position;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

#if UNITY_EDITOR
    //this code block only compiled on unity editor, wont be taken on build
    public Vector2 TestMoveDir;
    public int TestCounter;
    [ContextMenu("TestMoveButton")]
    void TestMoveButton()
    {
        MoveButton(TestMoveDir, TestCounter);
    }
#endif

    public void MoveButton(Vector2 dir, int counter)
    {
        //ini debug only, jangan lupa diapus atau bungkus ama directive #if UNITY_EDITOR
        Debug.Log($"dir: {dir}");
        Debug.Log($"counter: {counter}");

        //store the counter to local variable
        targetCounter = counter;
        //store the direction to local variable
        targetDir = dir;
        //move allow di set true
    }

    private void Move()
    {
        if (targetCounter > 0)
        {
            int nextX = waypointX + (int)targetDir.x;
            int nextY = waypointY + (int)targetDir.y;
            //kalau nextX < 0, nextX dipaksa 0
            if (nextX < 0)
            {
                nextX = 0;
            }
            //kalau nextX > boardSize-1, nextX dipaksa boardsize-1
            else if (nextX > boardSize - 1)
            {
                nextX = boardSize - 1;
            }
            if (nextY < 0)
            {
                nextY = 0;
            }
            else if (nextY > boardSize - 1)
            {
                nextY = boardSize - 1;
            }

            Vector3 nextWaypoint = waypoints[nextX, nextY];
            transform.position = Vector3.MoveTowards(transform.position, nextWaypoint, moveSpeed * Time.deltaTime); //moveSpeed * Time.deltaTime is move distance 

            //https://docs.unity3d.com/ScriptReference/Vector3.Equals.html
            //use the == operator to test two vectors for approximate equality.
            if (transform.position == nextWaypoint)
            {
                //TODO: check tile effect
                //waypointIndex += 1;
                waypointX += (int)targetDir.x;
                waypointY += (int)targetDir.y;
                targetCounter--;
            }
        }
    }
}
