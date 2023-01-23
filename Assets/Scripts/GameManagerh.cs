using UnityEngine;

public class GameManagerh : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
