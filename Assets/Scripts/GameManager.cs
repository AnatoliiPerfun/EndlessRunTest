using UnityEngine;



public class GameManager : MonoBehaviour 
{


    [SerializeField] PlayerMovement playerMovement;
    public static GameManager inst;


    public void IncrementScore ()
    {
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    private void Awake ()
    {
        inst = this;
    }
}