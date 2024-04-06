using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatChecker : MonoBehaviour
{
    [SerializeField] bool isCaptain;
    [SerializeField] bool isWitch;
    [SerializeField] bool isCowboy;

    public Rigidbody leftDoor;
    public Rigidbody rightDoor;

    public static bool correctCaptain = false;
    public static bool correctWitch = false;
    public static bool correctCowboy = false;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Captain" && isCaptain == true)
        {
            correctCaptain = true;
            Debug.Log("Captain is correct: " + correctCaptain);
        }
        else if (other.tag == "Captain" && isCaptain != true)
        {
            correctCaptain = false;
        }

        if (other.tag == "Witch" && isWitch == true)
        {
            correctWitch = true;
            Debug.Log("Witch is correct: " + correctWitch);
        }
        else if (other.tag == "Witch" && isWitch != true)
        {
            correctWitch = false;
        }

        if (other.tag == "Cowboy" && isCowboy == true)
        {
            correctCowboy = true;
            Debug.Log("Cowboy is correct: " + correctCowboy);
        }
        else if (other.tag == "Cowboy" && isCowboy != true)
        {
            correctCowboy = false;
        }
    }
    public void WinChecker()
    {
        if(correctCaptain == true && correctWitch == true && correctCowboy == true)
        {
            leftDoor.isKinematic = false;
            rightDoor.isKinematic = false;
            Debug.Log("Cabinet is open!");
        }
    }
}
