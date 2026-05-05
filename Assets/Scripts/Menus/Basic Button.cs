using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BasicButton : MonoBehaviour
{

    public Button button;

    InputAction submit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Button button = GetComponent<Button>();

        OnSelect();

        submit = InputSystem.actions.FindAction("Submit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSelect()
    {
        button.Select();
    }
}
