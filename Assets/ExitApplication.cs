using UnityEngine;


public class ExitApplication : MonoBehaviour
{
    public void Exit()
    {
         Application.Quit();
         Debug.Log("Exited");
    }
}
