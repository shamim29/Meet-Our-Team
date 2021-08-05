using UnityEngine;
using UnityEngine.UI;

public class CallButtonController : MonoBehaviour
{
    [Header("UI")]
    private Image ButtonImage;
    private Button Button;

    [Header("Data")]
    public User User;


    void Start()
    {
        Button = GetComponent<Button>();
        ButtonImage = GetComponent<Image>();

        ButtonImage.sprite = User.UserThamnail;

        Button.onClick.AddListener(ShowUser);

    }

    private void ShowUser()
    {
        UserPreviewController.instance.ShowUser(User);

    }
}
