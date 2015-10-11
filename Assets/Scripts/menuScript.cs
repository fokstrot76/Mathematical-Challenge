using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using UnityEngine.Events;

public class menuScript : MonoBehaviour
{
 
    public Button startGame;
    public Button exitGame;
    public InputField input;
    public GetInput name;
  

    public void Start()
    {
        input = GetComponent<InputField>();
    }

    public void MENU_ACTION_GoToPage(string sceneName)
    {

        if (string.IsNullOrEmpty(name.getNickName()))
        { 
            print("You haven't type your nickname");
        }
        else
        {
            Application.LoadLevel(sceneName);
            print("NickName: " + name.getNickName());
        }
        
    }

    public void ExitGame()
    {
        Application.Quit();
        print("Game Exit");
    }

}