using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public GameObject player;
    public static int diceSideThrown = 0;
    //public static Vector2 movementDir = Vector2.Zero;
    public static int player1StartWaypoint = 0;
    public static bool gameOver = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().moveAllowed = false;
        Coins.coinAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerMovement>().waypointIndex > player1StartWaypoint + diceSideThrown)
        {
            player.GetComponent<PlayerMovement>().moveAllowed = false;
            player1StartWaypoint = player.GetComponent<PlayerMovement>().waypointIndex - 1;
        }

        if (player.GetComponent<PlayerMovement>().waypointIndex == player.GetComponent<PlayerMovement>().waypoints.Length)
        {
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        /*
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player1.Move(movementDir, diceSideThrown)
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }*/
    }

    
}
